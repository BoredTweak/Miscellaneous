using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection;
using language_localizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Localization;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");
builder.Services.AddHttpContextAccessor();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "language_localizer", Version = "v1" });
});

var app = builder.Build();

app.UseRequestLocalization(options => 
{
    // Create a list of supported cultures
    var supportedCultures = new[] 
    { 
        "en-US",
        "es-MX" 
    };

    // Apply supported cultures and provide a default
    options.SetDefaultCulture(supportedCultures[0]);
    options.AddSupportedCultures(supportedCultures);
    options.AddSupportedUICultures(supportedCultures);
}); 

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "language_localizer v1"));
app.UseHttpsRedirection();

app.MapGet("/WeatherForecast", () => {
    return Results.Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
    {
        Date = DateTime.Now.AddDays(index),
        TemperatureC = Random.Shared.Next(-20, 55),
        Summary = WeatherForecast.SampleSummaries[Random.Shared.Next(WeatherForecast.SampleSummaries.Length)]
    })
    .ToArray());
});

app.MapPost("/WeatherForecast", ([FromServices] IStringLocalizer<WeatherForecast> _localizer, [FromBody] WeatherForecast weather) =>
{
    // Note - MinimalValidation is not shipping with .NET 6. 
    // It is a NuGet Package written by DamianEdwards 
    // https://github.com/DamianEdwards/MinimalValidation
    if (!MinimalValidation.TryValidate(weather, out var errors))
    {
        // Translate the error messages
        var translatedErrors = new Dictionary<string, string[]>();
        foreach(var error in errors)
        {
            var propertyName = error.Key;
            var translatedErrorMessages = error.Value.Select(errorDetail => 
                                       _localizer[errorDetail].ToString()).ToArray();

            translatedErrors.Add(error.Key, translatedErrorMessages);
        }
        return Results.ValidationProblem(translatedErrors);
    }

    return Results.Ok();
});

// See here the graveyard of an attempt at recreating the magic behind controllers explicitly.
// Error messages are produced, however localization has not yet been applied
//  
// app.MapPost("/WeatherForecast", ([FromServices] IObjectModelValidator _validator, [FromServices] IHttpContextAccessor _contextAccessor, [FromServices] IStringLocalizer<WeatherForecast> _localizer, [FromBody] WeatherForecast weather) =>
// {
//     var context = _contextAccessor.HttpContext;
//     var endpoint = context.GetEndpoint()!;
//     var routeData = new RouteData(context.Request.RouteValues);
//     var actionContext = new ActionContext(context, routeData, new ActionDescriptor());
//     _validator.Validate(
//         actionContext: actionContext, 
//         validationState: null, 
//         prefix: string.Empty, 
//         model: weather);
//     if(!actionContext.ModelState.IsValid)
//     {
//         // TODO - Localizing and mapping
//         // return Results.ValidationProblem(actionContext.ModelState); 
//     }

//     return Results.Ok();
// });

app.Run();

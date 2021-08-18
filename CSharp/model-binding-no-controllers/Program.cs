using Microsoft.AspNetCore.Mvc;
using model_binding;
using System.ComponentModel.DataAnnotations;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "model_binding", Version = "v1" });
});

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "model_binding v1"));
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

app.MapPost("/WeatherForecast", ([FromBody] WeatherForecast weather) =>
{
    // Note - MinimalValidation is not shipping with .NET 6. 
    // It is a NuGet Package written by DamianEdwards 
    // https://github.com/DamianEdwards/MinimalValidation
    if (!MinimalValidation.TryValidate(weather, out var errors))
    {
        return Results.ValidationProblem(errors);
    }

    return Results.Ok();
});

app.Run();

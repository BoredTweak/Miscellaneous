using System.Globalization;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Localization;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.AddMvc()
                .AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix) // en-US
                .AddDataAnnotationsLocalization();

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();

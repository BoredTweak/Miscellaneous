using Microsoft.AspNetCore.Mvc;
using Prometheus;
using System.ComponentModel.DataAnnotations;
using webapi_exporter;

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

app.UseRouting();
app.UseHttpMetrics();

app.UseEndpoints(endpoints =>
{
    endpoints.MapMetrics();
});

app.Run();

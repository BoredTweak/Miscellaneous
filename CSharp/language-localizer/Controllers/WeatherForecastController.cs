using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace language_localizer.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly IStringLocalizer<WeatherForecastController> _localizer;

    public WeatherForecastController(IStringLocalizer<WeatherForecastController> localizer)
    {
        _localizer = localizer;
    }

    [HttpGet]
    public IActionResult Get()
    {
        // Proof of concept that HelloWorldMessage gets translated per Accept-Language Header
        Console.WriteLine(_localizer["HelloWorldMessage"]); 

        return Ok(Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray());
    }

    [HttpPost]
    public IActionResult Create(WeatherForecast forecast)
    {
        return Ok();
    }
}

using System.ComponentModel.DataAnnotations;

namespace model_binding;

public class WeatherForecast
{
    private const int TEMPERATURE_OF_SUN = 5504;
    private const int TEMPERATURE_OF_ABSOLUTE_ZERO = -273;
    public static readonly string[] SampleSummaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    [Required]
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }

    [Required]
    [Range(TEMPERATURE_OF_ABSOLUTE_ZERO, TEMPERATURE_OF_SUN)] 
    // It's reasonable to assume that the weather's temperature is 
    // between absolute zero and the temperature of the sun.
    public int TemperatureC { get; set; }

    [Required]
    [StringLength(100, MinimumLength = 3)]
    // It's a summary, so let's keep it brief. That said, it should be at least something like `Hot`.
    public string? Summary { get; set; }
}


using System.ComponentModel.DataAnnotations;

namespace language_localizer;

public class WeatherForecast
{
    private const int TEMPERATURE_OF_SUN = 5504;
    private const int TEMPERATURE_OF_ABSOLUTE_ZERO = -273;

    [Required(ErrorMessage = "RequiredAttribute_ValidationError")]
    [DataType(DataType.Date)]
    public DateTime? Date { get; set; }

    [Required(ErrorMessage = "RequiredAttribute_ValidationError")]
    [Range(TEMPERATURE_OF_ABSOLUTE_ZERO, TEMPERATURE_OF_SUN, ErrorMessage = "RangeAttribute_ValidationError")] 
    // It's reasonable to assume that the weather's temperature is 
    // between absolute zero and the temperature of the sun.
    public int TemperatureC { get; set; }

    [Required(ErrorMessage = "RequiredAttribute_ValidationError")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "StringLengthAttribute_ValidationErrorIncludingMinimum")]
    // It's a summary, so let's keep it brief. That said, it should be at least something like `Hot`.
    public string? Summary { get; set; }
}

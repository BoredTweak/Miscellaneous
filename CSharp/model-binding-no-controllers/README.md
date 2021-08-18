# ASP.NET Model Binding Demonstration Without Controllers

This project aims to demonstrate Model Binding as described in [this documentation](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-6.0) in the use case wherein we align to the .NET 6 minimal APIs without Controllers.

Note that the controller-style of automatic model validation and return of ValidationProblemDetails does not occur in .NET 6 minimal APIs. Instead we must directly use [`System.ComponentModel.DataAnnotations.Validator.TryValidateObject`](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations.validator.tryvalidateobject?view=net-5.0) or instead create/depend on a wrapper for this method. 

This demonstration will include [Damian Edward](https://twitter.com/damianedwards)'s [MinimalValidation](https://github.com/DamianEdwards/MinimalValidation) package from NuGet installed by running `dotnet add package MinimalValidation --prerelease`.

## Data Annotations

The [`WeatherForecast`](WeatherForecast.cs) class is decorated with [Data Annotation validation attributes](https://docs.microsoft.com/en-us/aspnet/core/mvc/models/validation?view=aspnetcore-6.0#built-in-attributes).

## Controllers

Any controller decorated with the `ApiController` attribute automatically has validation done on serialized input. This allows the following demo:

- Run `dotnet run` from this directory.
- Run `curl -X POST "https://localhost:5001/WeatherForecast" -H  "accept: */*" -H  "Content-Type: application/json" -d '{\"temperatureC\":-1900,\"summary\":\"A1\"}'` 

OR

- Open [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html)
- POST to the `/WeatherForecast` endpoint with the following body
```json
{
    "temperatureC": -1900,
    "summary": "A1"
}
```

Note the output is [`ValidationProblemDetails`](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.mvc.validationproblemdetails?view=aspnetcore-5.0) per ASP.NET's [automatic HTTP 400 response](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-6.0#default-badrequest-response).

```json
{
  "type": "https://tools.ietf.org/html/rfc7231#section-6.5.1",
  "title": "One or more validation errors occurred.",
  "status": 400,
  "traceId": "00-bc9605575c9da9f032d1668f050ae594-4fd248b9c0edf95e-00",
  "errors": {
    "Date": [
      "The Date field is required."
    ],
    "Summary": [
      "The field Summary must be a string with a minimum length of 3 and a maximum length of 100."
    ],
    "TemperatureC": [
      "The field TemperatureC must be between -273 and 5504."
    ]
  }
}
```



# Language Localization Without Controllers

This project aims to demonstrate string localization in .NET without use of controllers.

The finding of this exercise was that localization needs more information from the attributes than currently exists in the output of MinimalValidation library alone.

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-6.0

## Testing Locally

- From a terminal instance in this directory, run `dotnet run`
- Run `curl -X POST "https://localhost:5001/WeatherForecast" -H  "Content-Type: application/json" -d '{\"temperatureC\":-1900,\"summary\":\"A1\"}'`

Note that the output validation errors are in en-US as the default culture.

- Run `curl -X POST "https://localhost:5001/WeatherForecast" -H  "accept-language: es-MX" -H  "Content-Type: application/json" -d '{\"temperatureC\":-1900,\"summary\":\"A1\"}'`

Note that the output validation errors are translated (maybe poorly) to the messages as defined in the [WeatherForecast.es-MX.resx](Resources/WeatherForecast.es-MX.resx) resource.

## Resx Files

This solution heavily relies on `resx` files. Workflows for adding and naming resource files can be found [here](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-6.0#resource-files-2).

Note that there are known issues with generation and editing of `resx` files on Linux and Mac OS. See [here for more details](https://github.com/dotnet/AspNetCore.Docs/issues/2501). 

## RootNamespace

You might browse this project and wonder why in 2021 we might need to have an `AssemblyInfo.cs`. Turns out this is still a requirement for String Localization if the namespacing doesn't perfectly match the directory structure naming. In the case of this project, the directory is named `language-localizer` but the Root Namespace is `language_localizer`.

See [here for the documentation on this requirement](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-6.0#rootnamespaceattribute-2).

## Translation Note

All translation comes in the most naive use case of https://translate.google.com/. Sincerest apologies for any mistranslations.

The default messages for DataAnnotations are largely stored in [this file](https://github.com/microsoft/referencesource/blob/master/System.ComponentModel.DataAnnotations/DataAnnotationsResources.resx).

/*
You might browse this project and wonder why in 2021 we might need to have an `AssemblyInfo.cs`. 
Turns out this is still a requirement for String Localization if the namespacing doesn't perfectly 
match the directory structure naming. In the case of this project, the directory is named `language-localizer` 
but the Root Namespace is `language_localizer`.

See here for the documentation on this requirement:
https://docs.microsoft.com/en-us/aspnet/core/fundamentals/localization?view=aspnetcore-6.0#rootnamespaceattribute-2
*/

using System.Reflection;
using Microsoft.Extensions.Localization;

[assembly: ResourceLocation("Resources")]
[assembly: RootNamespace("language_localizer")]
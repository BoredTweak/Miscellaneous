# .NET Standard Demo

This repository contains an example of a .NET Standard library being referenced by both Core and Framework applications/test libraries.

For more insights into .NET Standard refer to [the documentation](https://docs.microsoft.com/en-us/dotnet/standard/net-standard).

If you open [the solution](net-standard-demo.sln) in Visual Studio, you can run each of the available entry point projects (the two test projects and the two console applications) which vary from .NET Framework to .NET Core. 
- These projects target the same dependency project of ExtensionLibrary (which is a .NET Standard project.) 
- .NET Standard is acting as a type forwarder to a provided implementation of the standard libraries. 
- The runtime selected by the entry point project is providing the implementation.

**Note - This demo requires both .NET Core 3.1 and .NET Framework 4.6.1 to be installed.**

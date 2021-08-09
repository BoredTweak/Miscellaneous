# AutoMapper PoC

This C# WebAPI project aims to demonstrate [AutoMapper](https://automapper.org/). 

This project leverages the [wiki-toxicity-database](../../Postgres/wiki-toxicity-database/README.md) to bootstrap the effort and provide a more interesting starting point.

## AutoMapper

See [ToxicityAnnotationProfile.cs](Mapping/ToxicityAnnotationProfile.cs) for creation of a mapping profile.

See [Startup.cs](Startup.cs) for example of applying a mapping profile to the dependency injection built into .NET.

See [ToxicityAnnotationController.cs](Controllers/ToxicityAnnotationController.cs) for an example of consuming the `IMapper`.

## Entity Framework

Per [the dotnet CLI documentation](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) install dotnet-ef via `dotnet tool install --global dotnet-ef`.

Start up an instance of the data store per the [data store section](#data-store).

Scaffold the database on any schema update via running `dotnet ef dbcontext scaffold "Server=localhost;Database=toxicity;Port=5432;Username=docker;Password=docker;" Npgsql.EntityFrameworkCore.PostgreSQL --context "ToxicityContext" --no-onconfiguring --no-pluralize --context-namespace "automapper_poc" --context-dir "Infrastructure" --namespace "automapper_poc" --output-dir "Infrastructure"`

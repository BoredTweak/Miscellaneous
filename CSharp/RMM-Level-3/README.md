# Richardson Maturity Model Level 3

In the world of REST there is a concept known as HATEOAS or "Hypermedia as the engine of application state." Effectively, this implies that an API can inform a consuming client of links for further activity against a resource. Leonard Richardson did a breakout of REST API maturity through various characteristics such as resources defined via routes and verbs used for specific actions on resources. Richardson described a Richardson Maturity Model Level 3 (the final level of maturity) as a REST API that aligned with/implemented HATEOAS.

This concept is further described [here](https://www.w3schools.in/restful-web-services/rest-apis-hateoas-concept/) and [here](https://martinfowler.com/articles/richardsonMaturityModel.html).

## Run Locally

Spin up an instance of the database per [these instructions](#data-access).

From this directory, run `dotnet run`.

## Data Access

This WebAPI leverages the [wiki-toxicity-data](../../Postgres/wiki-toxicity-database/README.md) database. Follow along it's README to compose up an instance of the database.

The following command will configure the application with a relevant user secret.

```cli
dotnet user-secrets set ConnectionStrings:ToxicityDb "Username=docker;Password=docker;Host=host.docker.internal;Database=toxicity;"
```

### Entity Framework

This WebAPI uses Entity Framework to establish it's data access layer. 

In order to scaffold the database (generate Entity Framework code) in the webapi project you must first install the Entity Framework .NET CLI tools. `dotnet tool install --global dotnet-ef`

In order to update the scaffolded code first start up the docker-compose database instance per [the Database section of the README](#database).

Then run the following command from this directory.

```cli
dotnet ef dbcontext scaffold "Server=localhost;Database=toxicity;Port=5432;Username=docker;Password=docker;" Npgsql.EntityFrameworkCore.PostgreSQL --context "ToxicityContext" --no-onconfiguring --no-pluralize --context-namespace "Infrastructure" --context-dir "NewInfrastructure" --namespace "Infrastructure.Models" --output-dir "NewInfrastructure"
```

Delete [the Infrastructure directory](./Infrastructure/).

Rename the NewInfrastructure directory to Infrastructure.

For more information on Entity Framework look [here](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

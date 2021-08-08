# GraphQL PoC

GraphQL-Dotnet implementation extending the [wiki-toxicity-data](../../@shared/wiki-toxicity-data/README.md) database.

GraphQL documentation found [here](https://graphql.org/learn/).
GraphQL-Dotnet documenttion found [here](https://github.com/graphql-dotnet/graphql-dotnet) and [here](https://graphql-dotnet.github.io/docs/getting-started/introduction).
GraphQL-Dotnet code samples found [here](https://github.com/graphql-dotnet/examples).

## Running locally

This service is dependent on a running instance of the `wiki-toxicity-database`. Refer to [the data store section of this wiki](#data-store).

Run `dotnet run` from this directory to run [`webapi.csproj`](webapi.csproj).

Open a browser to [https://localhost:5001/ui/playground](https://localhost:5001/ui/playground).

Enter a query such as
```graphql
{
  toxicity_annotation(rev_id: "2232.0") {
    workerId
    toxicity
  }
}
```

## Data Store

Run the postgres toxicity instance via [the instructions in the readme](../../Postgres/wiki-toxicity-database/README.md).

### Entity Framework

Per [the dotnet CLI documentation](https://docs.microsoft.com/en-us/ef/core/cli/dotnet) install dotnet-ef via `dotnet tool install --global dotnet-ef`.

Start up an instance of the data store per the [data store section](#data-store).

Scaffold the database on any schema update via running `dotnet ef dbcontext scaffold "Server=localhost;Database=toxicity;Port=5432;Username=docker;Password=docker;" Npgsql.EntityFrameworkCore.PostgreSQL --context "ToxicityContext" --no-onconfiguring --no-pluralize --context-namespace "webapi" --context-dir "Infrastructure" --namespace "webapi" --output-dir "Infrastructure"`

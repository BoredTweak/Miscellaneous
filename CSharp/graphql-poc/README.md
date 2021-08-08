# GraphQL PoC

GraphQL-Dotnet implementation extending the [wiki-toxicity-data](../../@shared/wiki-toxicity-data/README.md) database.

GraphQL documentation found [here](https://graphql.org/learn/).
GraphQL-Dotnet documenttion found [here](https://github.com/graphql-dotnet/graphql-dotnet) and [here](https://graphql-dotnet.github.io/docs/getting-started/introduction).
GraphQL-Dotnet code samples found [here](https://github.com/graphql-dotnet/examples).

## Running locally

Run `dotnet run` from this directory to run [`webapi.csproj`](webapi.csproj).

Open a browser to [https://localhost:5001/ui/playground](https://localhost:5001/ui/playground).

Enter a query such as
```graphql
{
  toxicity_annotation(rev_id: "2") {
    worker_id
  }
}
```

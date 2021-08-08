# gRPC PoC

These projects demonstrate gRPC as implemented in C#. 

To run this PoC, open a terminal to this directory and run
```sh
dotnet run --project server/grpc-poc.csproj
dotnet run --project client/grpc-poc-client.csproj
```

Observe logs for Server and Client.


Note that both the Client and Server applications store [protocol buffer files](https://developers.google.com/protocol-buffers) and reference them in their `csproj` files.

For more information, refer to [the documentation](https://grpc.io/docs/languages/csharp/).

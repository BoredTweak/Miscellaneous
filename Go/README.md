# Playground for all things Go!

## Hello World

The [Hello World](hello-world) directory is self-describing as a "Hello, World" proof of concept. It additionally shows leveraging a function defined in another go file within the same package.

To run this example, navigate to the ./hello-world directory from a terminal instance and run `go run .`

## HTTP Example

The [HTTP Example](http-example) directory demonstrates an HTTP server with CRUD actions leveraging the 'net/http' library. It also demonstrates the use of a go module to define a dependency on Go 1.14.

To run this example, navigate to the ./http-example directory from a terminal instance and run `go run .`

To demonstrate it is working, you can run various curl commands against the available endpoints.
```
curl -X PUT localhost:8080
curl -X GET localhost:8080
curl -X DELETE localhost:8080
curl -X POST localhost:8080
curl -X PATCH localhost:8080
```

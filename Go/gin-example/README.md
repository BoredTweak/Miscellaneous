# Gin Example

Proof of concept Gin HTTP server created by following [this documentation](https://go.dev/doc/tutorial/web-service-gin).

## Running locally

Using OpenSSL generate a key in a [secrets](./secrets) directory.

```sh
openssl req -x509 -nodes -new -sha256 -days 1024 -newkey rsa:2048 -keyout server.key -out server.pem -subj "/C=US/CN=localhost"
openssl x509 -outform pem -in server.pem -out server.crt
```

Run locally via `go run .` from a terminal instance in this directory.

## Example curl commands

**Note these commands presume you're running them from a terminal instance in this directory. Change ./secrets/server.crt to whatever route is appropriate for your use case**

- `curl --cacert ./secrets/server.crt https://localhost:8080/albums` - Returns all items
- `curl --cacert ./secrets/server.crt https://localhost:8080/albums --include --header "Content-Type: application/json" --request "POST" --data '{"id": "4","title": "The Modern Sound of Betty Carter","artist": "Betty Carter","price": 49.99}'` - Creates a new item
- `curl --cacert ./secrets/server.crt https://localhost:8080/albums/2` - Fetches a specific item

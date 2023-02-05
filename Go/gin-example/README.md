# Gin Example

Proof of concept Gin HTTP server created by following [this documentation](https://go.dev/doc/tutorial/web-service-gin).

Run locally via `go run .` from a terminal instance in this directory.

## Example curl commands

- `curl http://localhost:8080/albums` - Returns all items
- `curl http://localhost:8080/albums --include --header "Content-Type: application/json" --request "POST" --data '{"id": "4","title": "The Modern Sound of Betty Carter","artist": "Betty Carter","price": 49.99}'` - Creates a new item
- `curl http://localhost:8080/albums/2` - Fetches a specific item

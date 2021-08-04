# Wiremock

Wiremock is a API mocking technology. For more insights please refer to [the documentation](http://wiremock.org/docs/)

## Running it

Use the docker-compose definition file via `docker compose up --build`. This hosts an image on port 8080 which can be tested via a GET call to [localhost:8080/annotations](http://localhost:8080/annotations).

## Testing it

To verify that wiremock is functioning as intended a postman collection is provided in the `tests` directory. To run this via `Newman` you can run `newman run .\tests\Toxicity.postman_collection.json`.

To install [`Newman`](https://www.npmjs.com/package/newman) run `npm install -g newman`.

# Queued Processing

Implementation of [Async Request Reply](https://learn.microsoft.com/en-us/azure/architecture/patterns/async-request-reply) through kafka topic processing.

## TODO

- (Optional) status endpoint for result of processing
- endpoint for processed results
- associate request with id for follow up
- Configure kafka ingest topic on kafka startup

## Running locally

- Create a .env file in this directory with a entry for: `NEW_RELIC_LICENSE_KEY=VALID_NEW_RELIC_LICENSE_KEY`
- From a terminal instance in this directory, run

```sh
docker compose up --build
```

- Open a browser instance to http://localhost:8080/swagger
  OR
- Run the locust tests in ./tests via `locust -f .\test.py -H http://localhost:8080 -u 10`

# Flask App

This project is a simple Flask application which increments a value in redis on every GET request to `/`.

## Running locally

A docker compose definition is provided in the root that will provide and configure the Redis dependency. Run `docker compose up` from a terminal instance in this directory then make a GET request to `http://localhost:5000/`

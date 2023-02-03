# Locust

This project encapsulates proof of concept tests for [Locust](https://locust.io/).

## Prerequisites

- [Python](https://www.python.org/downloads/) (3.7+)
- [Locust](https://docs.locust.io/en/stable/installation.html)
  - Run `pip3 install locust` to install locust

## Running locally

- This project needs a target to load test. For this purpose, run the [flask-app](../flask-app) project docker compose definition.
- Run `locust -f .\test.py -H http://localhost:5000` from a terminal instance in this directory.
- Open a browser to http://localhost:8089/ or http://0.0.0.0:8080/ and start the test.

# Hello World with AWS Lambda

This project is the result of following [this tutorial](https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-images.html).

## Prerequisites

- [Docker](https://www.docker.com/products/docker-desktop)

## Running Locally

- From a terminal instance in this directory run `docker build -t hello-world .`
- `docker run -p 9000:8080 hello-world:latest`
- `curl -X POST "http://localhost:9000/2015-03-31/functions/function/invocations" -d '{}'`

## GitHub Actions

- See [Lambda GitHub Action](../../.github/workflows/github-packages-push-lambda.yml) for workflow pushing this docker image to GitHub packages on dispatch.


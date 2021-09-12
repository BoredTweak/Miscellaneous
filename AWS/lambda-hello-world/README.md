# Hello World with AWS Lambda

This project is the result of following [this tutorial](https://docs.aws.amazon.com/lambda/latest/dg/gettingstarted-images.html).

## Prerequisites

- [Docker](https://www.docker.com/products/docker-desktop)

## Running Locally

- From a terminal instance in this directory run `docker build -t hello-world .`
- `docker run -p 9000:8080 hello-world:latest`
- `curl -X POST "http://localhost:9000/2015-03-31/functions/function/invocations" -d '{}'`

## Running in AWS

### Costs
- Lambda itself is [pretty cheap](https://aws.amazon.com/lambda/pricing/) for hobby/learning devs
- In order to trigger Lambda from anything a dev needs to enable input triggers. To be able to `curl` your lambda would require an [API Gateway which is not free](https://aws.amazon.com/api-gateway/pricing/)

### Deployment

Deployment can be done through [SAM](https://aws.amazon.com/serverless/sam/)
- `sam build` from a terminal instance in this directory
- Follow `sam deploy --guided` workflow for setup

## GitHub Actions

- See [Lambda GitHub Action](../../.github/workflows/github-packages-push-lambda.yml) for workflow pushing this docker image to GitHub packages on dispatch. Note that Lambda does not currently support container images that are outside of ECR.

## Additional Resources
- [SAM guide](https://docs.aws.amazon.com/serverless-application-model/latest/developerguide/serverless-getting-started-hello-world.html)

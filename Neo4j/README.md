# Neo4j Playground

This is a playground for spinning up an instance of Neo4j using Docker Compose.

## Prerequisites

Before getting started, make sure you have the following installed on your machine:

- Docker: [Install Docker](https://docs.docker.com/get-docker/)

## Getting Started

1. Start the Neo4j container:

    ```shell
    docker-compose up -d
    ```

2. Access Neo4j Browser:

    - URL: [http://localhost:7474](http://localhost:7474)

## Customizing Neo4j Configuration

If you want to customize the Neo4j configuration, you can modify the `docker-compose.yml` file. Refer to the [Neo4j Docker documentation](https://hub.docker.com/_/neo4j) for available configuration options.

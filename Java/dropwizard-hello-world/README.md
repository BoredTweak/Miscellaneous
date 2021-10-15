# Dropwizard Hello World

This is a dive into how to set up a new project with Dropwizard. 

The output found in this project is inspired and assisted by [this documentation](https://www.dropwizard.io/en/latest/getting-started.html)

## Prerequisites

- Java
- [Maven](http://maven.apache.org/)

## Generation

- Grab a release from [the Dropwizard GitHub](https://github.com/dropwizard/dropwizard/releases/)
- Extract `dropwizard-archetypes` to a directory.
- Navigate to that directory with a terminal instance
- run `mvn archetype:generate -DarchetypeGroupId="io.dropwizard.archetypes" -DarchetypeArtifactId="java-simple" -DarchetypeVersion="2.0.25"`

## Running Locally

How to start the test application
---

1. Run `mvn clean install` to build your application
1. Start application with `java -jar target/test-1.0-SNAPSHOT.jar server config.yml`
1. To check that your application is running enter url `http://localhost:8080`
1. Try `http://localhost:8080/hello-world`
1. Try `http://localhost:8080/hello-world?name=Joe`

Health Check
---

To see your applications health enter url `http://localhost:8081/healthcheck`

# Kafka C# Demonstration

This project demonstrates creating a Kafka Producer in C#. 

## Running Locally

Run [this kafka docker compose definition][docker-compose] to have a kafka instance available at http://localhost:29092/ then run `dotnet run` from this directory.

A successful message production will look like `Delivered 'test' to 'test [[0]] @0'`

## Additional Reading

- [Kafka .NET GitHub][kafka-dotnet-gh]

[docker-compose]: ../../Kafka/docker-compose.yml
[kafka-dotnet-gh]: https://github.com/confluentinc/confluent-kafka-dotnet

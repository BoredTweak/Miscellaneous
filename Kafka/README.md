# Kafka

This directory aims to collect spikes done around [Kafka][main-technology].

There is additionally a [docker-compose definition][docker-compose] to spin up an instance of kafka exposed on http://localhost:29092. Note that this may take a significant amount of computing resources as well as a few minutes to complete start-up.

## Demos

- [C# Producer Application][csharp-producer]
- [Python Producer and Consumer][python-producer-consumer]

## Additional Resources

- [The White Paper that inspired this research spike][white-paper]

[main-technology]: https://kafka.apache.org/
[docker-compose]: docker-compose.yml
[white-paper]: http://notes.stephenholiday.com/Kafka.pdf
[csharp-producer]: csharp-producer/README.md
[python-producer-consumer]: python/README.md

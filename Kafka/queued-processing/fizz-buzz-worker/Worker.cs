namespace fizz_buzz_worker;
using Confluent.Kafka;
using Confluent.Kafka.Admin;
using StackExchange.Redis;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IConnectionMultiplexer _redis;

    private const string KAFKA_INGEST_TOPIC = "raw-input";
    private const string KAFKA_OUTPUT_TOPIC = "processed-input";

    public Worker(ILogger<Worker> logger, IConnectionMultiplexer multiplexer)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _redis = multiplexer ?? throw new ArgumentNullException(nameof(multiplexer));
    }

    private string Process(int input)
    {
        if (input % 3 == 0 && input % 5 == 0)
        {
            return "fizz-buzz";
        }
        else if (input % 3 == 0)
        {
            return "fizz";
        }
        else if (input % 5 == 0)
        {
            return "buzz";
        }
        else
        {
            return input.ToString();
        }
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var kafkaBroker = Environment.GetEnvironmentVariable("KAFKA_BROKER") ?? "localhost:29092";
        var redisDb = _redis.GetDatabase();
        var config = new ConsumerConfig
        {
            BootstrapServers = kafkaBroker,
            GroupId = "fizz-buzz-worker",
            AutoOffsetReset = AutoOffsetReset.Earliest
        };

        using (var c = new ConsumerBuilder<string, int>(config).Build())
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                Console.WriteLine("Broker configured as: " + kafkaBroker);

                // TODO - Move this out to the kafka startup
                Console.WriteLine("Validating ingest topic");
                ValidateIngestTopic(kafkaBroker);

                c.Subscribe(KAFKA_INGEST_TOPIC);

                var consumeResult = c.Consume();
                var input = consumeResult.Message.Value;
                var output = Process(input);
                Console.WriteLine($"Input: {input}, Output: {output}");

                // Output to redis
                var redisKey = consumeResult.Message.Key;
                redisDb.StringSet(redisKey, output);
            }
        }
    }

    // Validate that ingest topic exists and create it if it does not. This is a temporary workaround.
    private void ValidateIngestTopic(string kafkaBroker)
    {
        var adminClientConfig = new AdminClientConfig { BootstrapServers = kafkaBroker };
        using (var ac = new AdminClientBuilder(adminClientConfig).Build())
        {
            var metadata = ac.GetMetadata(TimeSpan.FromSeconds(10));
            var topicExists = metadata.Topics.Exists(t => t.Topic == KAFKA_INGEST_TOPIC);
            if (!topicExists)
            {
                Console.WriteLine("Ingest topic does not exist, creating it");
                var topicSpec = new TopicSpecification { Name = KAFKA_INGEST_TOPIC, ReplicationFactor = 1, NumPartitions = 1 };
                ac.CreateTopicsAsync(new List<TopicSpecification> { topicSpec });
            }
        }
    }
}

using Confluent.Kafka;
using NewRelic.Api.Agent;
using StackExchange.Redis;

/// <summary>
/// This class is responsible for dispatching the input to the Kafka topic.
/// </summary>
public class FizzBuzzDispatcher : IDispatcher
{
    private readonly IConnectionMultiplexer _redis;

    public FizzBuzzDispatcher(IConnectionMultiplexer redis)
    {
        _redis = redis ?? throw new ArgumentNullException(nameof(redis));
    }

    private const string KAFKA_TOPIC = "raw-input";

    [Trace]
    public async Task<Guid?> Dispatch(int input)
    {
        var kafkaBroker = Environment.GetEnvironmentVariable("KAFKA_BROKER") ?? "localhost:29092";
        Console.WriteLine("Broker configured as: " + kafkaBroker);

        var config = new ProducerConfig { BootstrapServers = kafkaBroker };
        using (var p = new ProducerBuilder<string, int>(config).Build())
        {
            try
            {
                var identifier = Guid.NewGuid();

                // Write a message to redis to indicate that the message has been dispatched
                var redisDb = _redis.GetDatabase();
                var redisKey = identifier.ToString();
                await redisDb.StringSetAsync(redisKey, "Dispatched");

                // Write to kafka topic
                Console.WriteLine("Calling Produce");
                var dr = await p.ProduceAsync(KAFKA_TOPIC, new Message<string, int> { Key = identifier.ToString(), Value = input });

                Console.WriteLine($"Delivered '{dr.Value}' with key '{dr.Key}' to '{dr.TopicPartitionOffset}'");
                return identifier;
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                return null;
            }
        }
    }

    [Trace]
    public async Task<string?> GetStatus(Guid identifier)
    {
        var redisDb = _redis.GetDatabase();
        var redisKey = identifier.ToString();
        return await redisDb.StringGetAsync(redisKey);
    }
}
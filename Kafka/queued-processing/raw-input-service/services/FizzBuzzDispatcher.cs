using Confluent.Kafka;

/// <summary>
/// This class is responsible for dispatching the input to the Kafka topic.
/// </summary>
public class FizzBuzzDispatcher: IDispatcher {
    private const string KAFKA_TOPIC = "raw-input";
    public async Task<bool> Dispatch(int input) {
        var kafkaBroker = Environment.GetEnvironmentVariable("KAFKA_BROKER") ?? "localhost:29092";
        Console.WriteLine("Broker configured as: " + kafkaBroker);

        var config = new ProducerConfig { BootstrapServers = kafkaBroker };
        using (var p = new ProducerBuilder<Null, int>(config).Build())
        {
            try
            {
                Console.WriteLine("Calling Produce");
                var dr = await p.ProduceAsync(KAFKA_TOPIC, new Message<Null, int> { Value=input });
                Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
                return true;
            }
            catch (ProduceException<Null, string> e)
            {
                Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                return false;
            }
        }
    }
}
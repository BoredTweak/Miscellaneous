
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

public interface IBackgroundServiceQueue 
{
    ValueTask QueueAsync(string message);
    ValueTask<string> DequeueAsync(CancellationToken token);
}

public class BackgroundServiceQueue : IBackgroundServiceQueue
{
    private readonly Channel<string> _channel;

    public BackgroundServiceQueue()
    {
        var options = new BoundedChannelOptions(3)
        {
            FullMode = BoundedChannelFullMode.Wait
        };
        
        _channel = Channel.CreateBounded<string>(options);
    }

    public async ValueTask<string> DequeueAsync(CancellationToken token)
    {
        return await _channel.Reader.ReadAsync(token);
    }

    public async ValueTask QueueAsync(string message)
    {
        await _channel.Writer.WriteAsync(message);
    }
}
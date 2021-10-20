using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

public class ExceptionalHostedService : BackgroundService
{
    private readonly ILogger<ExceptionalHostedService> _logger;
    private readonly IBackgroundServiceQueue _queue;

    public ExceptionalHostedService(ILogger<ExceptionalHostedService> logger, IBackgroundServiceQueue queue) =>
        (_logger, _queue) = (logger, queue);

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("ExceptionalHostedService is running!");

        while (!stoppingToken.IsCancellationRequested)
        {
            var messageItem = await _queue.DequeueAsync(stoppingToken);
            
            try
            {
                _logger.LogInformation($"ExceptionalHostedService dequeued the message: {messageItem}");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, 
                    $"Error occurred executing {messageItem}.", nameof(messageItem));
            }
        }
    }
}
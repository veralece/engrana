namespace Engrana.Service;

public sealed class QueueService(
    IBackgroundTaskQueue taskQueue,
    ILogger<QueueService> logger,
    IServiceProvider serviceProvider
) : BackgroundService
{
    protected override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation(
            """
            {Name} is running.
            Tap W to add a work item to the 
            background queue.
            """,
            nameof(QueueService)
        );

        return ProcessTaskQueueAsync(stoppingToken);
    }

    private async Task ProcessTaskQueueAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                Func<IServiceProvider, CancellationToken, ValueTask>? workItem =
                    await taskQueue.DequeueAsync(stoppingToken);

                await workItem(serviceProvider, stoppingToken);
            }
            catch (OperationCanceledException)
            {
                // Prevent throwing if stoppingToken was signaled
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error occurred executing task work item.");
            }
        }
    }

    public override async Task StopAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation($"{nameof(QueueService)} is stopping.");

        await base.StopAsync(stoppingToken);
    }
}

using System.Threading.Channels;

namespace Engrana.Service;

public interface IBackgroundTaskQueue
{
    ValueTask QueueBackgroundWorkItemAsync(
        Func<IServiceProvider, CancellationToken, ValueTask> workItem
    );

    ValueTask<Func<IServiceProvider, CancellationToken, ValueTask>> DequeueAsync(
        CancellationToken cancellationToken
    );
}

public sealed class BackgroundTaskQueue : IBackgroundTaskQueue
{
    private readonly Channel<Func<IServiceProvider, CancellationToken, ValueTask>> _queue;
    private readonly SemaphoreSlim _signal = new(0);

    public BackgroundTaskQueue(int capacity)
    {
        BoundedChannelOptions options = new(capacity) { FullMode = BoundedChannelFullMode.Wait };
        _queue = Channel.CreateBounded<Func<IServiceProvider, CancellationToken, ValueTask>>(
            options
        );
    }

    public async ValueTask QueueBackgroundWorkItemAsync(
        Func<IServiceProvider, CancellationToken, ValueTask> workItem
    )
    {
        ArgumentNullException.ThrowIfNull(workItem);
        await _queue.Writer.WriteAsync(workItem);
        _signal.Release();
    }

    public async ValueTask<Func<IServiceProvider, CancellationToken, ValueTask>> DequeueAsync(
        CancellationToken cancellationToken
    )
    {
        await _signal.WaitAsync(cancellationToken);
        Func<IServiceProvider, CancellationToken, ValueTask>? workItem =
            await _queue.Reader.ReadAsync(cancellationToken);

        return workItem;
    }
}

using Microsoft.Extensions.Hosting;

namespace Koala.AttachmentConsumerService;

public class AttachmentConsumerHandlerWorker : IHostedService
{
    public Task StartAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}
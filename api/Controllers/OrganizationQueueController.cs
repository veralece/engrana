using Engrana.Domain.Configuration;
using Engrana.Services;

namespace Engrana.Controllers;

public class OrganizationQueueController(
    ILogger<OrganizationQueueController> logger,
    OrganizationQueueService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<OrganizationQueue>(service, taskQueue)
{
    private readonly ILogger<OrganizationQueueController> _logger = logger;
}

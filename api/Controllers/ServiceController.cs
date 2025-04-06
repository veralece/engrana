using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceController(
    ILogger<ServiceController> logger,
    ServiceService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Service>(service, taskQueue)
{
    private readonly ILogger<ServiceController> _logger = logger;
}

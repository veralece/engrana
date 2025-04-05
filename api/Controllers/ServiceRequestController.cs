using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ServiceRequestController(
    ILogger<ServiceRequestController> logger,
    ServiceRequestService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ServiceRequest>(service, taskQueue)
{
    private readonly ILogger<ServiceRequestController> _logger = logger;
}

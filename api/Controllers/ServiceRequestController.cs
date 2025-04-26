using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ServiceRequestController(
    ILogger<ServiceRequestController> logger,
    IService<ServiceRequest> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ServiceRequest>(service, taskQueue)
{
    private readonly ILogger<ServiceRequestController> _logger = logger;
}

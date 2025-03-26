using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ServiceRequestController(
    ILogger<ServiceRequestController> logger,
    ServiceRequestService service
) : GenericController<ServiceRequest>(service)
{
    private readonly ILogger<ServiceRequestController> _logger = logger;
}

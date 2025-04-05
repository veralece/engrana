using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class OrganizationController(
    ILogger<OrganizationController> logger,
    OrganizationService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Organization>(service, taskQueue)
{
    private readonly ILogger<OrganizationController> _logger = logger;
}

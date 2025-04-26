using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class OrganizationController(
    ILogger<OrganizationController> logger,
    IService<Organization> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Organization>(service, taskQueue)
{
    private readonly ILogger<OrganizationController> _logger = logger;
}

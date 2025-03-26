using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class OrganizationController(
    ILogger<OrganizationController> logger,
    OrganizationService service
) : GenericController<Organization>(service)
{
    private readonly ILogger<OrganizationController> _logger = logger;
}

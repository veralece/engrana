using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ConfigurationItemController(
    ILogger<ConfigurationItemController> logger,
    ConfigurationItemService service
) : GenericController<ConfigurationItem>(service)
{
    private readonly ILogger<ConfigurationItemController> _logger = logger;
}

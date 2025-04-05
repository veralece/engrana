using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class ConfigurationItemController(
    ILogger<ConfigurationItemController> logger,
    ConfigurationItemService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ConfigurationItem>(service, taskQueue)
{
    private readonly ILogger<ConfigurationItemController> _logger = logger;
}

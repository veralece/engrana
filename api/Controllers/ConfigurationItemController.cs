using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ConfigurationItemController(
    ILogger<ConfigurationItemController> logger,
    ConfigurationItemService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ConfigurationItem>(service, taskQueue)
{
    private readonly ILogger<ConfigurationItemController> _logger = logger;
}

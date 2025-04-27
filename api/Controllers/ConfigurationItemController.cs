using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class ConfigurationItemController(
    ILogger<ConfigurationItem> logger,
    IService<ConfigurationItem> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<ConfigurationItem>(service, taskQueue, logger) { }

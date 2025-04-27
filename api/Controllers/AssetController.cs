using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class AssetController(
    ILogger<Asset> logger,
    IService<Asset> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Asset>(service, taskQueue, logger) { }

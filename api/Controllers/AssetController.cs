using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class AssetController(
    ILogger<AssetController> logger,
    IService<Asset> service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Asset>(service, taskQueue)
{
    private readonly ILogger<AssetController> _logger = logger;
}

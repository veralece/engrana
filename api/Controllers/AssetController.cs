using Engrana.Domain;
using Engrana.Services;

namespace Engrana.Controllers;

public class AssetController(
    ILogger<AssetController> logger,
    AssetService service,
    IBackgroundTaskQueue taskQueue
) : GenericController<Asset>(service, taskQueue)
{
    private readonly ILogger<AssetController> _logger = logger;
}

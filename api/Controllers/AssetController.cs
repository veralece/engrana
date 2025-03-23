using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class AssetController(ILogger<AssetController> logger, AssetService assetService)
    : GenericController<Asset>(assetService)
{
    private readonly ILogger<AssetController> _logger = logger;
}

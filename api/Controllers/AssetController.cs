using Engrana.Domain;
using Engrana.Service;

namespace Engrana.Controllers;

public class AssetController(ILogger<AssetController> logger, AssetService service)
    : GenericController<Asset>(service)
{
    private readonly ILogger<AssetController> _logger = logger;
}

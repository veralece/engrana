using Engrana.Domain;
using Engrana.Service;
using Microsoft.AspNetCore.Mvc;

namespace Engrana.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssetController : ControllerBase
    {
        private readonly ILogger<AssetController> _logger;
        private readonly AssetService _assetService;

        public AssetController(ILogger<AssetController> logger, AssetService assetService)
        {
            _logger = logger;
            _assetService = assetService;
        }

        [HttpGet(Name = "GetAssets")]
        public async Task<IEnumerable<Asset>> Get()
        {
            return await _assetService.GetAllAssetsAsync();
        }
    }
}

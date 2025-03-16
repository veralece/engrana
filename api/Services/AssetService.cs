using Engrana.Domain;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Service
{
    public class AssetService(EngranaContext context)
    {
        private readonly EngranaContext _context = context;

        public async Task<IEnumerable<Asset>> GetAllAssetsAsync()
        {
            return await _context.Asset.ToListAsync();
        }
    }
}

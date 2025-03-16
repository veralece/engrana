using Engrana.Domain;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure
{
    public class EngranaContext(DbContextOptions<EngranaContext> options) : DbContext(options)
    {
        public DbSet<Asset> Asset { get; set; }
    }
}

using Engrana.Domain;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure;

public class EngranaContext(DbContextOptions<EngranaContext> options) : DbContext(options)
{
    public DbSet<Asset> Asset { get; set; }
    public DbSet<ConfigurationItem> ConfigurationItem { get; set; }
    // public DbSet<Manufacturer> Manufacturer { get; set; }
}

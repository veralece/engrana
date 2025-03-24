using Engrana.Domain;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure;

public class EngranaContext(DbContextOptions<EngranaContext> options) : DbContext(options)
{
    public DbSet<Asset> Asset { get; set; }
    public DbSet<ConfigurationItem> ConfigurationItem { get; set; }

    // public DbSet<Manufacturer> Manufacturer { get; set; }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {

    // }

    public async Task<int> SaveChangesAsync()
    {
        foreach (var entry in ChangeTracker.Entries<EntityBase>())
        {
            switch (entry.State)
            {
                case EntityState.Added:
                    entry.Entity.Created = DateTime.Now.ToUniversalTime();
                    entry.Entity.LastModified = DateTime.Now.ToUniversalTime();
                    break;
                case EntityState.Modified:
                    entry.Entity.LastModified = DateTime.Now.ToUniversalTime();
                    break;
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    entry.Entity.IsDeleted = true;
                    entry.Entity.Deleted = DateTime.Now.ToUniversalTime();
                    entry.Entity.LastModified = DateTime.Now.ToUniversalTime();
                    break;
            }
        }
        return await base.SaveChangesAsync(new CancellationToken());
    }
}

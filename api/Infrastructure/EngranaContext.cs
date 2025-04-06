using Engrana.Domain;
using Engrana.Domain.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure;

public class EngranaContext(DbContextOptions<EngranaContext> options) : DbContext(options)
{
    #region Domain

    public DbSet<Asset> Asset { get; set; }
    public DbSet<Change> Change { get; set; }
    public DbSet<ConfigurationItem> ConfigurationItem { get; set; }
    public DbSet<ContactInformation> ContactInformation { get; set; }
    public DbSet<Incident> Incident { get; set; }
    public DbSet<KnowledgeArticle> KnowledgeArticle { get; set; }
    public DbSet<Manufacturer> Manufacturer { get; set; }
    public DbSet<Organization> Organization { get; set; }
    public DbSet<PhysicalAddress> PhysicalAddress { get; set; }
    public DbSet<Service> Service { get; set; }
    public DbSet<ServiceRequest> ServiceRequest { get; set; }

    #endregion
    #region Domain.Configuration


    public DbSet<Workflow> Workflow { get; set; }
    public DbSet<WorkflowStep> WorkflowStep { get; set; }
    public DbSet<Trigger> Trigger { get; set; }
    public DbSet<CompareStatement> CompareStatement { get; set; }
    public DbSet<StringPropertyState> PropertyStateString { get; set; }
    public DbSet<StringProperty> StringProperty { get; set; }
    public DbSet<StringSet> StringSet { get; set; }
    public DbSet<StringEntry> StringEntry { get; set; }
    public DbSet<DatePropertyState> PropertyStateDate { get; set; }
    public DbSet<DateProperty> DateProperty { get; set; }
    public DbSet<DateSet> DateSet { get; set; }
    public DbSet<DateEntry> DateEntry { get; set; }
    public DbSet<NumberPropertyState> PropertyStateNumber { get; set; }
    public DbSet<NumberProperty> NumberProperty { get; set; }
    public DbSet<NumberSet> NumberSet { get; set; }
    public DbSet<NumberEntry> NumberEntry { get; set; }
    public DbSet<BooleanPropertyState> PropertyStateBoolean { get; set; }
    public DbSet<BooleanProperty> BooleanProperty { get; set; }
    public DbSet<BooleanEntry> BooleanEntry { get; set; }

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
#pragma warning disable CS8602 // Rethrow to preserve stack details
        modelBuilder
            .Entity<ConfigurationItem>()
            .Property(ci => ci.Version)
            .HasConversion(v => v.ToString(), v => Version.Parse(v));
#pragma warning restore CS8602 // Rethrow to preserve stack details
    }

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

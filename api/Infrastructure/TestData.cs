using Engrana.Domain;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure.Test;

public class TestData
{
    public static void Seed(DbContext context, bool _)
    {
        var testAsset = context.Set<Asset>().FirstOrDefault(a => a.Name == "V-Server-Test");
        if (testAsset == null)
        {
            var assetGuid = Guid.NewGuid();
            Asset asset =
                new()
                {
                    Id = assetGuid,
                    Name = "VMWare-Test",
                    AssetTag = "1234567890",
                    Description = "Test Server used for virtualization.",
                    SerialNumber = "0987654321",
                    Location = "Office 420",
                    Manufacturer = new()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dell - Information Technology Company",
                        Urls = ["https://www.dell.com/en-us"],
                        Addresses =
                        [
                            new()
                            {
                                Id = Guid.NewGuid(),
                                Name = "Dell Phoenix",
                                Address = "3151 W Behrend Dr",
                                City = "Phoenix",
                                State = "Arizona",
                                ZipCode = "85027"
                            }
                        ],
                        Contacts =
                        [
                            new()
                            {
                                Id = Guid.NewGuid(),
                                Name = "Support",
                                Phone = "(623) 582-0581"
                            }
                        ]
                    }
                };
            Service service = new() { Id = Guid.NewGuid(), Name = "VMWare", };
            ConfigurationItem serviceCI =
                new()
                {
                    Name = "VMWare",
                    Service = service,
                    Version = new(17, 6, 2)
                };

            ConfigurationItem assetCI =
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "VMWare-Test",
                    Asset = asset,
                    Version = new(2025, 26100, 3476)
                };

            serviceCI.DownstreamConfigurationItems.Add(assetCI);
            assetCI.UpstreamConfigurationItems.Add(serviceCI);

            context.Set<Asset>().Add(asset);
            context.Set<Service>().Add(service);
            context.Set<ConfigurationItem>().Add(assetCI);
            context.Set<ConfigurationItem>().Add(serviceCI);

            context.SaveChanges();
        }
    }

    public static async Task SeedAsync(
        DbContext context,
        bool _,
        CancellationToken cancellationToken
    )
    {
        var testAsset = context
            .Set<Asset>()
            .FirstOrDefaultAsync(a => a.Name == "V-Server-Test", cancellationToken);
        if (testAsset == null)
        {
            var assetGuid = Guid.NewGuid();
            Asset asset =
                new()
                {
                    Id = assetGuid,
                    Name = "VMWare-Test",
                    AssetTag = "1234567890",
                    Description = "Test Server used for virtualization.",
                    SerialNumber = "0987654321",
                    Location = "Office 420",
                    Manufacturer = new()
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dell - Information Technology Company",
                        Urls = ["https://www.dell.com/en-us"],
                        Addresses =
                        [
                            new()
                            {
                                Id = Guid.NewGuid(),
                                Name = "Dell Phoenix",
                                Address = "3151 W Behrend Dr",
                                City = "Phoenix",
                                State = "Arizona",
                                ZipCode = "85027"
                            }
                        ],
                        Contacts =
                        [
                            new()
                            {
                                Id = Guid.NewGuid(),
                                Name = "Support",
                                Phone = "(623) 582-0581"
                            }
                        ]
                    }
                };
            Service service = new() { Id = Guid.NewGuid(), Name = "VMWare", };
            ConfigurationItem serviceCI =
                new()
                {
                    Name = "VMWare",
                    Service = service,
                    Version = new(17, 6, 2)
                };

            ConfigurationItem assetCI =
                new()
                {
                    Id = Guid.NewGuid(),
                    Name = "VMWare-Test",
                    Asset = asset,
                    Version = new(2025, 26100, 3476)
                };

            serviceCI.DownstreamConfigurationItems.Add(assetCI);
            assetCI.UpstreamConfigurationItems.Add(serviceCI);

            context.Set<Asset>().Add(asset);
            context.Set<Service>().Add(service);
            context.Set<ConfigurationItem>().Add(assetCI);
            context.Set<ConfigurationItem>().Add(serviceCI);

            await context.SaveChangesAsync(cancellationToken);
        }
    }
}

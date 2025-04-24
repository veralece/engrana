using Engrana.Domain;
using Engrana.Domain.Configuration;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure.Test;

public class TestData
{
    public static void Seed(DbContext context, bool _)
    {
        Organization org = new() { Id = Guid.NewGuid(), Name = "Information Technology" };
        OrganizationQueue orgQueue =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Application Development",
                Organization = org
            };

        List<Service> services =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana",
                ServiceOwner = org
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "VMWare",
                ServiceOwner = org
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Reboot Server",
                ServiceOwner = org
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana Configuration Change",
                ServiceOwner = org
            }
        ];

        List<ServiceCategory> categories =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Virtualization Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Reboot Server")]
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Engrana Configuration Change")]
            }
        ];

        List<ServiceRequest> requests =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Organizations",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Assets",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Services",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue,
                Description =
                    @"Services can range from a single action performed by resources to an 
                        application service that performs many services. E.g., Facilities Service 
                        Action of Repairing Infrastructure (such as Paint, Electrical, Plumbing) to 
                        IT Services - both automated and manual - such as Virtualization Software 
                        and Resetting Passwords."
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Configuration Items",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Knowledge Articles",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
        ];

        Project project =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana Implementation",
                ServiceRequests = requests
            };

        Portfolio portfolio =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "IT Portfolio",
                Projects = [project]
            };

        org.Portfolio = portfolio;

        Asset asset =
            new()
            {
                Id = Guid.NewGuid(),
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

        ConfigurationItem serviceCI =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "VMWare",
                Service = services.GetByName("VMWare"),
                Version = new(17, 6, 2)
            };

        ConfigurationItem assetCI =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "VMWare-Test",
                Description = "Windows Server 2025",
                Asset = asset,
                Version = new(2025, 26100, 3476)
            };

        serviceCI.DownstreamConfigurationItems.Add(assetCI);
        assetCI.UpstreamConfigurationItems.Add(serviceCI);

        context.Set<Organization>().Add(org);
        context.Set<OrganizationQueue>().Add(orgQueue);
        context.Set<Asset>().Add(asset);
        context.Set<Project>().Add(project);
        context.Set<Portfolio>().Add(portfolio);
        context.Set<ServiceRequest>().AddRange(requests);
        context.Set<ServiceCategory>().AddRange(categories);
        context.Set<Service>().AddRange(services);
        context.Set<ConfigurationItem>().Add(assetCI);
        context.Set<ConfigurationItem>().Add(serviceCI);

        context.SaveChanges();
    }

    public static async Task SeedAsync(
        DbContext context,
        bool _,
        CancellationToken cancellationToken
    )
    {
        Organization org = new() { Id = Guid.NewGuid(), Name = "Information Technology" };
        OrganizationQueue orgQueue =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Application Development",
                Organization = org
            };

        List<Service> services =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana",
                ServiceOwner = org
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "VMWare",
                ServiceOwner = org
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Reboot Server",
                ServiceOwner = org
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana Configuration Change",
                ServiceOwner = org
            }
        ];

        List<ServiceCategory> categories =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Virtualization Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Reboot Server")]
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Engrana Configuration Change")]
            }
        ];

        List<ServiceRequest> requests =
        [
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Organizations",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Assets",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Services",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue,
                Description =
                    @"Services can range from a single action performed by resources to an 
                        application service that performs many services. E.g., Facilities Service 
                        Action of Repairing Infrastructure (such as Paint, Electrical, Plumbing) to 
                        IT Services - both automated and manual - such as Virtualization Software 
                        and Resetting Passwords."
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Configuration Items",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Create Knowledge Articles",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
        ];

        Project project =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "Engrana Implementation",
                ServiceRequests = requests
            };

        Portfolio portfolio =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "IT Portfolio",
                Projects = [project]
            };

        org.Portfolio = portfolio;

        Asset asset =
            new()
            {
                Id = Guid.NewGuid(),
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

        ConfigurationItem serviceCI =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "VMWare",
                Service = services.GetByName("VMWare"),
                Version = new(17, 6, 2)
            };

        ConfigurationItem assetCI =
            new()
            {
                Id = Guid.NewGuid(),
                Name = "VMWare-Test",
                Description = "Windows Server 2025",
                Asset = asset,
                Version = new(2025, 26100, 3476)
            };

        serviceCI.DownstreamConfigurationItems.Add(assetCI);
        assetCI.UpstreamConfigurationItems.Add(serviceCI);

        await context.Set<Organization>().AddAsync(org, cancellationToken);
        await context.Set<OrganizationQueue>().AddAsync(orgQueue, cancellationToken);
        await context.Set<Asset>().AddAsync(asset, cancellationToken);
        await context.Set<Project>().AddAsync(project, cancellationToken);
        await context.Set<Portfolio>().AddAsync(portfolio, cancellationToken);
        await context.Set<ServiceRequest>().AddRangeAsync(requests, cancellationToken);
        await context.Set<ServiceCategory>().AddRangeAsync(categories, cancellationToken);
        await context.Set<Service>().AddRangeAsync(services, cancellationToken);
        await context.Set<ConfigurationItem>().AddAsync(assetCI, cancellationToken);
        await context.Set<ConfigurationItem>().AddAsync(serviceCI, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}

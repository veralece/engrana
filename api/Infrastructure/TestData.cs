using Engrana.Domain;
using Engrana.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Infrastructure.Test;

public class TestData
{
    public static void Seed(DbContext context, bool _)
    {
        Organization org =
            new()
            {
                Id = new Guid("1D6BB7CD-C70B-4189-AD55-F4F3EAD98815"),
                Name = "Information Technology"
            };
        OrganizationQueue orgQueue = new() { Name = "Application Development", Organization = org };

        List<Service> services =
        [
            new() { Name = "Engrana", ServiceOwner = org },
            new() { Name = "VMWare", ServiceOwner = org },
            new() { Name = "Reboot Server", ServiceOwner = org },
            new() { Name = "Engrana Configuration Change", ServiceOwner = org }
        ];

        List<ServiceCategory> categories =
        [
            new()
            {
                Name = "Virtualization Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Reboot Server")]
            },
            new()
            {
                Name = "Engrana Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Engrana Configuration Change")]
            }
        ];

        List<ServiceRequest> requests =
        [
            new()
            {
                Name = "Create Organizations",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Name = "Create Assets",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
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
                Name = "Create Configuration Items",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Name = "Create Knowledge Articles",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
        ];

        Project project = new() { Name = "Engrana Implementation", ServiceRequests = requests };

        Portfolio portfolio = new() { Name = "IT Portfolio", Projects = [project] };

        org.Portfolio = portfolio;

        Asset asset =
            new()
            {
                Name = "VMWare-Test",
                AssetTag = "1234567890",
                Description = "Test Server used for virtualization.",
                SerialNumber = "0987654321",
                Location = "Office 420",
                Manufacturer = new()
                {
                    Name = "Dell - Information Technology Company",
                    Urls = ["https://www.dell.com/en-us"],
                    Addresses =
                    [
                        new()
                        {
                            Name = "Dell Phoenix",
                            Address = "3151 W Behrend Dr",
                            City = "Phoenix",
                            State = "Arizona",
                            ZipCode = "85027"
                        }
                    ],
                    Contacts = [new() { Name = "Support", Phone = "(623) 582-0581" }]
                }
            };

        ConfigurationItem serviceCI =
            new()
            {
                Name = "VMWare",
                Service = services.GetByName("VMWare"),
                Version = new(17, 6, 2)
            };

        ConfigurationItem assetCI =
            new()
            {
                Name = "VMWare-Test",
                Description = "Windows Server 2025",
                Asset = asset,
                Version = new(2025, 26100, 3476)
            };

        serviceCI.DownstreamConfigurationItems.Add(assetCI);
        assetCI.UpstreamConfigurationItems.Add(serviceCI);

        Guid workflowId = Guid.NewGuid();
        ConditionStatement conditionStatement =
            new()
            {
                Name = "Name is eq to IT Applications statement",
                StringPropertyStateConditions =
                [
                    new()
                    {
                        Name = "Text_PS:IT Applications",
                        PropertyName = "Name",
                        Value = "IT Applications"
                    }
                ]
            };

        Workflow workflow =
            new()
            {
                Id = workflowId,
                Name = "Change Org Name to Information Technology",
                WorkflowType = WorkflowType.Triggered,
                ConditionSteps =
                [
                    new()
                    {
                        Order = 0,
                        Name = "Name is eq to IT Applications step",
                        ConditionStatement = conditionStatement
                    }
                ],
                DataSteps =
                [
                    new()
                    {
                        Name = "Update Name Step",
                        Order = 1,
                        StringPropertyToUpdate =
                        [
                            new()
                            {
                                Name = "Text_PS:Information Technology",
                                PropertyName = "Name",
                                Value = "Information Technology"
                            }
                        ],
                    }
                ]
            };

        Trigger trigger =
            new()
            {
                Name = "Check Org Name Changed to IT Applications",
                WorkflowId = workflowId,
                TriggerEntity = EntityType.Organization,
                ActionType = ActionType.OnChanged,
                ConditionStatement = conditionStatement
            };

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
        context.Set<Workflow>().Add(workflow);
        context.Set<Trigger>().Add(trigger);

        context.SaveChanges();
    }

    public static async Task SeedAsync(
        DbContext context,
        bool _,
        CancellationToken cancellationToken
    )
    {
        Organization org =
            new()
            {
                Id = new Guid("1D6BB7CD-C70B-4189-AD55-F4F3EAD98815"),
                Name = "Information Technology"
            };
        OrganizationQueue orgQueue = new() { Name = "Application Development", Organization = org };

        List<Service> services =
        [
            new() { Name = "Engrana", ServiceOwner = org },
            new() { Name = "VMWare", ServiceOwner = org },
            new() { Name = "Reboot Server", ServiceOwner = org },
            new() { Name = "Engrana Configuration Change", ServiceOwner = org }
        ];

        List<ServiceCategory> categories =
        [
            new()
            {
                Name = "Virtualization Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Reboot Server")]
            },
            new()
            {
                Name = "Engrana Services",
                ServiceCategoryOwner = org,
                Services = [services.GetByName("Engrana Configuration Change")]
            }
        ];

        List<ServiceRequest> requests =
        [
            new()
            {
                Name = "Create Organizations",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Name = "Create Assets",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
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
                Name = "Create Configuration Items",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
            new()
            {
                Name = "Create Knowledge Articles",
                Service = services.GetByName("Engrana Configuration Change"),
                ServiceCategory = categories.GetByName("Engrana Services"),
                AssignedQueue = orgQueue
            },
        ];

        Project project = new() { Name = "Engrana Implementation", ServiceRequests = requests };

        Portfolio portfolio = new() { Name = "IT Portfolio", Projects = [project] };

        org.Portfolio = portfolio;

        Asset asset =
            new()
            {
                Name = "VMWare-Test",
                AssetTag = "1234567890",
                Description = "Test Server used for virtualization.",
                SerialNumber = "0987654321",
                Location = "Office 420",
                Manufacturer = new()
                {
                    Name = "Dell - Information Technology Company",
                    Urls = ["https://www.dell.com/en-us"],
                    Addresses =
                    [
                        new()
                        {
                            Name = "Dell Phoenix",
                            Address = "3151 W Behrend Dr",
                            City = "Phoenix",
                            State = "Arizona",
                            ZipCode = "85027"
                        }
                    ],
                    Contacts = [new() { Name = "Support", Phone = "(623) 582-0581" }]
                }
            };

        ConfigurationItem serviceCI =
            new()
            {
                Name = "VMWare",
                Service = services.GetByName("VMWare"),
                Version = new(17, 6, 2)
            };

        ConfigurationItem assetCI =
            new()
            {
                Name = "VMWare-Test",
                Description = "Windows Server 2025",
                Asset = asset,
                Version = new(2025, 26100, 3476)
            };

        serviceCI.DownstreamConfigurationItems.Add(assetCI);
        assetCI.UpstreamConfigurationItems.Add(serviceCI);

        Guid workflowId = Guid.NewGuid();
        ConditionStatement conditionStatement =
            new()
            {
                Name = "Name is eq to IT Applications statement",
                StringPropertyStateConditions =
                [
                    new()
                    {
                        Name = "Text_PS:IT Applications",
                        PropertyName = "Name",
                        Value = "IT Applications"
                    }
                ]
            };

        Workflow workflow =
            new()
            {
                Id = workflowId,
                Name = "Change Org Name to Information Technology",
                WorkflowType = WorkflowType.Triggered,
                ConditionSteps =
                [
                    new()
                    {
                        Order = 0,
                        Name = "Name is eq to IT Applications step",
                        ConditionStatement = conditionStatement
                    }
                ],
                DataSteps =
                [
                    new()
                    {
                        Name = "Update Name Step",
                        Order = 1,
                        StringPropertyToUpdate =
                        [
                            new()
                            {
                                Name = "Text_PS:Information Technology",
                                PropertyName = "Name",
                                Value = "Information Technology"
                            }
                        ],
                    }
                ]
            };

        Trigger trigger =
            new()
            {
                Name = "Check Org Name Changed to IT Applications",
                WorkflowId = workflowId,
                TriggerEntity = EntityType.Organization,
                ActionType = ActionType.OnChanged,
                ConditionStatement = conditionStatement
            };

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
        await context.Set<Workflow>().AddAsync(workflow, cancellationToken);
        await context.Set<Trigger>().AddAsync(trigger, cancellationToken);
        await context.SaveChangesAsync(cancellationToken);
    }
}

using Engrana.Domain;
using Engrana.Domain.Configuration;
using Engrana.Infrastructure;
using Engrana.Infrastructure.Test;
using Engrana.Services;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Configuration
{
    public static class EngranaConfig
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddHostedService<BackgroundQueueService>();
            builder.Services.AddSingleton<IBackgroundTaskQueue>(_ => new BackgroundTaskQueue(100));
            builder.Services.AddScoped<IService<Asset>, AssetService>();
            builder.Services.AddScoped<IService<Change>, ChangeService>();
            builder.Services.AddScoped<IService<ConfigurationItem>, ConfigurationItemService>();
            builder.Services.AddScoped<IService<ContactInformation>, ContactInformationService>();
            builder.Services.AddScoped<IService<Incident>, IncidentService>();
            builder.Services.AddScoped<IService<KnowledgeArticle>, KnowledgeService>();
            builder.Services.AddScoped<IService<Manufacturer>, ManufacturerService>();
            builder.Services.AddScoped<IService<Organization>, OrganizationService>();
            builder.Services.AddScoped<IService<OrganizationQueue>, OrganizationQueueService>();
            builder.Services.AddScoped<IService<PhysicalAddress>, PhysicalAddressService>();
            builder.Services.AddScoped<IService<Portfolio>, PortfolioService>();
            builder.Services.AddScoped<IService<Profile>, ProfileService>();
            builder.Services.AddScoped<IService<Project>, ProjectService>();
            builder.Services.AddScoped<IService<ServiceCategory>, ServiceCategoryService>();
            builder.Services.AddScoped<IService<Service>, ServiceService>();
            builder.Services.AddScoped<IService<ServiceRequest>, ServiceRequestService>();
            builder.Services.AddScoped<IService<Workflow>, WorkflowService>();
        }

        public static void RegisterConnectionStrings(WebApplicationBuilder builder)
        {
            string? connectionString = null;

            if (builder.Environment.IsDevelopment())
            {
                connectionString = builder.Configuration["ConnStrDev"];
            }

            builder.Services.AddDbContextFactory<EngranaContext>(options =>
            {
                options
                    .UseSqlServer(connectionString, builder => builder.EnableRetryOnFailure())
                    .UseSeeding(TestData.Seed)
                    .UseAsyncSeeding(TestData.SeedAsync);
                ;
            });
        }
    }
}

using Engrana.Domain;
using Engrana.Infrastructure;
using Engrana.Service;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Configuration
{
    public static class EngranaConfig
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddHostedService<QueueService>();
            builder.Services.AddSingleton<IBackgroundTaskQueue>(_ => new BackgroundTaskQueue(100));
            builder.Services.AddScoped<IService<Asset>, AssetService>();
            builder.Services.AddScoped<IService<ConfigurationItem>, ConfigurationItemService>();
            builder.Services.AddScoped<IService<Change>, ChangeService>();
            builder.Services.AddScoped<IService<ContactInformation>, ContactInformationService>();
            builder.Services.AddScoped<IService<Incident>, IncidentService>();
            builder.Services.AddScoped<IService<KnowledgeArticle>, KnowledgeService>();
            builder.Services.AddScoped<IService<Manufacturer>, ManufacturerService>();
            builder.Services.AddScoped<IService<Organization>, OrganizationService>();
            builder.Services.AddScoped<IService<PhysicalAddress>, PhysicalAddressService>();
            builder.Services.AddScoped<IService<ServiceRequest>, ServiceRequestService>();
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
                options.UseSqlServer(connectionString, builder => builder.EnableRetryOnFailure());
            });
        }
    }
}

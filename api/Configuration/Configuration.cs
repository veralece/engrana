using Engrana.Infrastructure;
using Engrana.Service;
using Microsoft.EntityFrameworkCore;

namespace Engrana.Configuration
{
    public static class EngranaConfig
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<AssetService>();
            builder.Services.AddScoped<ConfigurationItemService>();
        }

        public static void RegisterConnectionStrings(WebApplicationBuilder builder)
        {
            string? connectionString = null;

            if (builder.Environment.IsDevelopment())
            {
                connectionString = builder.Configuration["ConnStrDev"];
            }

            builder.Services.AddDbContext<EngranaContext>(options =>
            {
                options.UseSqlServer(connectionString, builder => builder.EnableRetryOnFailure());
            });
        }
    }
}

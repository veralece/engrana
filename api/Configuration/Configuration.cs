using Engrana.Service;

namespace Engrana.Configuration
{
    public static class EngranaConfig
    {
        public static void RegisterServices(WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<AssetService>();
        }

        public static string? RegisterConnectionStrings(WebApplicationBuilder builder)
        {
            return builder.Environment.IsDevelopment()
                ? builder.Configuration["ConnStrDev"]
                : default;
        }
    }
}

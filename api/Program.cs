using Engrana.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;
using static Microsoft.AspNetCore.Http.StatusCodes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

EngranaConfig.RegisterServices(builder);
EngranaConfig.RegisterConnectionStrings(builder);

CorsConfiguration corsConfiguration = new();
builder.Configuration.Bind(nameof(CorsConfiguration), corsConfiguration);
if (builder.Environment.IsDevelopment())
{
    builder.WebHost.UseUrls(corsConfiguration.Origins);

    builder.Services.AddCors(ops =>
    {
        ops.AddPolicy(
            name: corsConfiguration.Policy,
            builder =>
            {
                builder.WithOrigins(corsConfiguration.Origins).AllowAnyMethod().AllowAnyHeader();
            }
        );
    });

    builder.Services.AddHttpsRedirection(options =>
    {
        options.RedirectStatusCode = Status307TemporaryRedirect;
        options.HttpsPort = 5173;
    });
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    if (args.Contains("rebuild"))
    {
        using var scope = app.Services.CreateScope();
        using var context = scope.ServiceProvider.GetService<EngranaContext>();
        if (context is not null)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();
        }
    }
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(corsConfiguration.Policy);
}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();

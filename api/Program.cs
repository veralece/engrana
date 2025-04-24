using Engrana.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

EngranaConfig.RegisterServices(builder);
EngranaConfig.RegisterConnectionStrings(builder);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    using (var scope = app.Services.CreateScope())
    {
        using var context = scope.ServiceProvider.GetService<EngranaContext>();
        if (context is not null)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();
        }
    }
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

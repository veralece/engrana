using Engrana.Configuration;
using Engrana.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
string? _dbConnectionString;

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

_dbConnectionString = EngranaConfig.RegisterConnectionStrings(builder);
EngranaConfig.RegisterServices(builder);
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<EngranaContext>(options =>
    {
        options.UseSqlServer(_dbConnectionString, builder => builder.EnableRetryOnFailure());
    });
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

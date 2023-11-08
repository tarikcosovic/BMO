using BMO.Api.Authentication;
using BMO.Api.Mappings;
using BMO.Api.Migrations;
using BMO.Api.Models;
using BMO.Api.Repositories;
using BMO.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(x =>
                x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

//register db context
builder.Services.AddDbContext<BmodbContext>(opt =>
{
    opt.UseSqlServer(DbContextMigrationsHandler.GetDatabaseConnectionString(builder), config =>
    {
        config.EnableRetryOnFailure();
    });

    opt.EnableDetailedErrors();
});

//register logger
builder.Services.AddLogging(config =>
{
    config.AddConsole();
});

//register cors
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
});
//register custom authentication middleware
builder.Services.AddAuthentication("Basic").AddScheme<BasicAuthenticationOption, BasicAuthenticationHandler>("Basic", null);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("User",
        authBuilder =>
        {
            authBuilder.RequireRole("User").Build();
        });

    options.AddPolicy("Administrator",
      authBuilder =>
      {
          authBuilder.RequireRole("Administrator").Build();
      });
});

//register autoMapper
builder.Services.AddAutoMapper((typeof(GameProfile).Assembly));

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

//Create and migrate/seed the database if one does already not exist
await DbContextMigrationsHandler.PrepareDatabase(app, builder);

app.Run();

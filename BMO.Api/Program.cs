using AutoMapper;
using BMO.Api.Configuration;
using BMO.Api.Mappings;
using BMO.Api.Models;
using BMO.Api.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();


//register db context
builder.Services.AddDbContext<BmodbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("BMO-Database"), config =>
    {
        config.CommandTimeout(1);
    });

    opt.EnableDetailedErrors();
});

//register logger
builder.Services.AddLogging(config =>
{
    config.AddConsole();
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
app.UseHttpsRedirection();

app.MapControllers();

app.Run();

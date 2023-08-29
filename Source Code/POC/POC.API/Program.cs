using Microsoft.EntityFrameworkCore;
using POC.API.AppLayerHandlers.CommandHandlers;
using POC.API.InfrastructureLayer.Repositories.BaseRepositories.Commands;
using POC.API.InfrastructureLayer.Repositories.BaseRepositories.Queries;
using POC.API.InfrastructureLayer.Repositories.Commands;
using POC.API.InfrastructureLayer.Repositories.Queries;
using POC.API.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var _configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
//builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(CreateBankHandler).Assembly));
builder.Services.AddDbContext<PocdbContext>(options =>
        options.UseSqlServer(_configuration.GetConnectionString("SQLConnection")));
//builder.Services.AddDbContext<PocdbContext>();
//builder.Services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));
//builder.Services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));
builder.Services.AddTransient<IBankCommandRepository, BankCommandRepository>();
builder.Services.AddTransient<IBankQueryRepository, BankQueryRepository>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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

app.UseAuthorization();

app.MapControllers();

app.Run();

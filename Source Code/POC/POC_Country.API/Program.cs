using Microsoft.EntityFrameworkCore;
using POC_Country.API.Infrastructure.Repositories.Commands;
using POC_Country.API.Infrastructure.Repositories.Queries;
using POC_Country.API.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

var _configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddDbContext<PocdbContext>(options =>
        options.UseSqlServer(_configuration.GetConnectionString("SQLConnection")));
builder.Services.AddTransient<ICountryCommandRepository, CountryCommandRepository>();
builder.Services.AddTransient<ICountryQueryRepository, CountryQueryRepository>();

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

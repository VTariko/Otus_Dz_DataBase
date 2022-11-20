using System.Reflection;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using otus.dz.DataAccess.Interfaces;
using otus.dz.DataAccess.Interfaces.Repositories;
using otus.dz.DataAccess.PostgreSQL;
using otus.dz.DataAccess.PostgreSQL.Repositories;
using otus.dz.UseCases.UserHandlers.AddUser;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.WebHost.ConfigureKestrel(x => { x.ListenAnyIP(7210); });
builder.WebHost.UseUrls("http://*:7210");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSwaggerGenNewtonsoftSupport();

builder.Services.AddMediatR(Assembly.GetAssembly(typeof(AddUserCommand)));
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddMaps(Assembly.GetAssembly(typeof(Program)));
});
var mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICardRepository, CardRepository>();
builder.Services.AddScoped<IBankAccountRepository, BankAccountRepository>();


var host = Environment.GetEnvironmentVariable("DATABASE_HOST");
var port = Environment.GetEnvironmentVariable("DATABASE_PORT");
var database = Environment.GetEnvironmentVariable("DATABASE_NAME");
var username = Environment.GetEnvironmentVariable("DATABASE_LOGIN");
var password = Environment.GetEnvironmentVariable("DATABASE_PASSWORD");
        
var connectionString = $"Host={host};Port={port};Database={database};Username={username};Password={password}";
builder.Services.AddDbContext<AppDbContext>(opt => opt.UseNpgsql(connectionString));

var app = builder.Build();
app.UsePathBase("/api");

if (!app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();


app.UseEndpoints(endpoints => { endpoints.MapControllers(); });

app.Run();
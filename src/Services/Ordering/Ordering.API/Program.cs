using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddApplicationServices()
    .AddInfrastructureServices(builder.Configuration)
    .AddApiServices();
//Add services to the container.

var app = builder.Build();

//Configure the HTTP request pipeline.

app.Run();

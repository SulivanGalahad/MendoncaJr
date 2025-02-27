using Login.API.DbContexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LoginDbContext>(
    o => o.UseSqlServer(builder.Configuration["ConnectionStrings:DbOne"])
    );

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();

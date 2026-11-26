using CatalogAPI.Repositories;
using CatalogAPI.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

//DI configuration
builder.Services.AddScoped<IProductRepository, ProductJsonRepository>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();
//Middleware configuration

app.MapControllers();
app.Run();
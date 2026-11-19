using OrderProcess.Models;
using OrderProcess.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();
OrderRepository repo = new OrderRepository();

app.MapGet("api/orders", () =>{
    return repo.GetAll();
});

app.MapGet("api/orders/{id}", (int id) =>{
    return repo.GetById(id);
});

app.MapPost("api/orders/", (Order order) => {
    repo.Create(order);
    return $"Order ID: {order.OrderId} added";
});

app.MapPut("api/orders/{id}", (Order order) => {
    repo.Update(order);
    return $"Order at Id: {order.OrderId} updated";
});

app.MapDelete("api/orders/{id}", (int id) => {
    repo.Delete(id);
    return $"Order at Id: {id} deleted";
});


app.Run();

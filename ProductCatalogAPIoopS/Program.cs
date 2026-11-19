
using Catalog.Models;

using Catalog.Repositories;


var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ProductRepository repo=new ProductRepository();

app.MapGet("/api/products",()=>{return repo.GetAll();});  //R

app.MapGet("/api/products/{id}",(int id)=>{
        return repo.GetById(id);
});

app.MapPost("/api/products",( Product product)=>{
        repo.Create(product);
        return $"Product {product.Title} added";
});  //C

app.MapPut("/api/products/{id}",( Product product)=>{ 
    repo.Update(product);
    return $"Product {product.Title} updated";
});      //U

app.MapDelete("/api/products/{id}",(int id)=>{
    repo.Delete(id);
    return $"Product with Id: {id} deleted";
});       //D

app.Run();
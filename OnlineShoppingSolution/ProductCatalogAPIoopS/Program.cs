
using  Entities;
using Catalog.Repositories;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

ProductRepository repo=new ProductRepository();

app.MapGet("/api/products",()=>{
    return repo.GetAll();
});  //R

app.MapGet("/api/products/{id}",(int id)=>{
        return repo.GetById(id);
});

app.MapPost("/api/products",( Product product)=>{
        repo.Create(product);
        return "Louts added";
});  //C

app.MapPut("/api/products/{id}",( Product product)=>{ 
    repo.Update(product);
    return "Rose updated";
});      //U

app.MapDelete("/api/products/{id}",(int id)=>{
    repo.Delete(id);
    return " Jasmine Deleted";
});       //D

app.Run();
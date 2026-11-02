//Library: Microsoft.aspnet;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


app.MapGet("/", () =>
{
    return "Welcome to Transflower ASP.NET Core!";
});

app.MapGet("/api/mentor", () =>
{
    return new
    {
        Name = "Ravi Tambade",
        Organization = "Transflower",
        Role = "Chief Mentor"
    };
});

//get all
app.MapGet("/api/products", () =>
{
    return new[]
    {
        new { Id = 1, Name = "Laptop" },
        new { Id = 2, Name = "Keyboard" },
        new { Id=3, Name="Notebook"}
    };
});

//get by id
app.MapGet("/api/products/{id}",()=>{
    return new { Id = 78, Name = "Laptop" };
});

app.Run();
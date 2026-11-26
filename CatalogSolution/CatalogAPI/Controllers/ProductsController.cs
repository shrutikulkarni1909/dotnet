using Microsoft.AspNetCore.Mvc;
using CatalogAPI.Entites;
using CatalogAPI.Repositories;
namespace CatalogAPI.Controllers;



[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    
    [HttpGet]
    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        ProductRepository repo=new ProductRepository();
        products=repo.GetAll();
        return products;
    }

    // GET: api/products/1
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {
        ProductRepository repo = new ProductRepository();

        Product product = repo.GetById(id);

        if (product == null)
        {
            return NotFound("Product not found");
        }

        return Ok(product);
    }

    // POST: api/products
    [HttpPost]
    public ActionResult<Product> Add(Product product)
    {
        ProductRepository repo = new ProductRepository();

        repo.Create(product);

        return CreatedAtAction(
            nameof(GetById),
            new { id = product.Id },
            product
        );
    }

    // PUT: api/products/1
    [HttpPut("{id}")]
    public IActionResult Update(int id, Product product)
    {
        if (id != product.Id)
        {
            return BadRequest("Product ID mismatch");
        }

        ProductRepository repo = new ProductRepository();

        bool result = repo.Update(product);

        if (!result)
        {
            return NotFound("Product not found");
        }

        return Ok("Product updated successfully");
    }

    // DELETE: api/products/1
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        ProductRepository repo = new ProductRepository();

        bool result = repo.Delete(id);

        if (!result)
        {
            return NotFound("Product not found");
        }

        return Ok("Product deleted successfully");
    }
}
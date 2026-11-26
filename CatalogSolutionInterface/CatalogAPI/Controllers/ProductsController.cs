using Microsoft.AspNetCore.Mvc;
using CatalogAPI.Entites;
using CatalogAPI.Repositories;
using CatalogAPI.Services;
namespace CatalogAPI.Controllers;



[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private IProductService _service;
    //construcor DI
    public ProductsController(IProductService svc)
    {
        this._service=svc;
    }

    [HttpGet]
    public List<Product> GetAll()
    {
        List<Product> products = new List<Product>();
        products=this._service.GetAllProducts();
       return products;
    }

    // GET: api/products/1
    [HttpGet("{id}")]
    public ActionResult<Product> GetById(int id)
    {

        Product product = _service.GetProductById(id);
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
      this._service.Intsert(product);

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

        bool result = _service.Update(product);
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
        bool result = _service.Delete(id);
        if (!result)
        {
            return NotFound("Product not found");
        }
        return Ok("Product deleted successfully");
    }
}
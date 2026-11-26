using CustomerAPI.Models;
using CustomerAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using CustomerAPI.Services;
namespace CustomerAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CustomerController : ControllerBase
{

    private ICustomerService _service;

    public CustomerController(ICustomerService svc)
    {
        this._service = svc;
    }
    [HttpGet]
    public List<Customer> GetAll()
    {
        List<Customer> customers = new List<Customer>();
        customers=this._service.GetAll();
        return customers;
    }

    [HttpGet("{id}")]
    public ActionResult<Customer> GetById(int id)
    {
        Customer customer = this._service.GetById(id);
        if(customer == null)
        {
            return NotFound("Customer not found");
        }

        return Ok(customer);
    }

    [HttpPost]
    public ActionResult<Customer> Add(Customer customer)
    {
        this._service.Add(customer);
        return CreatedAtAction(
            nameof(GetById),
            new { id = customer.Id},
            customer
        );

    }

    [HttpPut("{id}")]

    public IActionResult Update(int id, Customer customer)
    {
        if (id != customer.Id)
        {
            return BadRequest("Customer ID did not match");
        }

        CustomerRepository repo = new CustomerRepository();
        bool result = this._service.Update(id,customer);

        if (!result)
        {
            return NotFound("Product not found");
        }
        return Ok("Customer updated");
    }

    [HttpDelete("{id}")]

    public IActionResult Delete(int id)
    {
        bool result = this._service.Delete(id);

        if (!result)
        {
            return NotFound("Customer not found");
        }
        return Ok("Customer deleted successfully");
    }
}
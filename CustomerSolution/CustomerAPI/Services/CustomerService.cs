namespace CustomerAPI.Services;
using CustomerAPI.Repositories;
using CustomerAPI.Models;

public class CustomerService : ICustomerService
{
    private ICustomerRepository _repository;

    public CustomerService(ICustomerRepository repo)
    {
        this._repository = repo;
    }
    
    public List<Customer> GetAll()
    {
        List<Customer> customers = new List<Customer>();
        customers=this._repository.GetAll();
        return customers;
    }

    public Customer GetById(int id)
    {
        Customer customer = this._repository.GetById(id);
        return customer;
    }

    public bool Add(Customer customer)
    {
        bool status = this._repository.Add(customer);
        return status;
    }

    public bool Update(int id, Customer customertoUpdate)
    {
        if (id != customertoUpdate.Id)
        {
            return false;
        }

        bool result = this._repository.Update(id, customertoUpdate);

        if (!result)
        {
            return false;
        }
        return true;
    }


    public bool Delete(int id)
    {
        bool result = this._repository.Delete(id);

        if (!result)
        {
            return false;
        }
        return true;
    }
}
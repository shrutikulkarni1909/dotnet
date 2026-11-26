namespace CustomerAPI.Repositories;
using CustomerAPI.Helpers;
using CustomerAPI.Models;

public class CustomerRepository : ICustomerRepository
{
    string filePath=@"E:\Projects\dotnet\CustomerSolution\CustomerAPI\Data\customers.json";

    public CustomerRepository(){ }
    public List<Customer> GetAll()
    {
        List<Customer> allCustomers = PersistManager.Load(filePath);
        return allCustomers;
    }

    public Customer GetById(int id)
    {
        List<Customer> allCustomers = GetAll();
        Customer theCustomer = null;
        for(int i = 0; i < allCustomers.Count; i++)
        {
            if(allCustomers[i].Id == id)
            {
                theCustomer = allCustomers[i];
                return theCustomer;
            }
        }
        return theCustomer;

    }

    public bool Add(Customer customer)
    {
        bool status = false;
        List<Customer> allCustomers = GetAll();
        allCustomers.Add(customer);
        PersistManager.Dump(filePath, allCustomers);
        status = true;
        return status;
    }

    public bool Update(int id, Customer customertoUpdate)
    {
        bool status= false;
      
        List<Customer> allCustomers = GetAll();
        for(int i = 0; i < allCustomers.Count; i++)
        {
            if(allCustomers[i].Id == customertoUpdate.Id)
            {
                allCustomers[i] = customertoUpdate;
                status = true;
            }
        }
        PersistManager.Dump(filePath, allCustomers);
        return status;
    }

    public bool Delete(int id)
    {
        List<Customer> allCustomers = GetAll();
        Customer existingCustomer = allCustomers.FirstOrDefault(c => c.Id == id);
        if (existingCustomer == null)
        {
            return false;
        }
        allCustomers.Remove(existingCustomer);
        PersistManager.Dump(filePath, allCustomers);
        return true;
    }
}
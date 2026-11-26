namespace CustomerAPI.Repositories;
using CustomerAPI.Models;

public interface ICustomerRepository
{
     List<Customer> GetAll();
     Customer GetById(int id);
     bool Add(Customer customer);
     bool Update(int id, Customer customertoUpdate);

     bool Delete(int id);

}
namespace CustomerAPI.Services;
using CustomerAPI.Models;

public interface ICustomerService
{
     List<Customer> GetAll();
     Customer GetById(int id);
     bool Add(Customer customer);
     bool Update(int id, Customer customer);
     bool Delete(int id);

}
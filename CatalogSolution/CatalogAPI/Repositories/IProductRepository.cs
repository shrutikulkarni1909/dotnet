namespace CatalogAPI.Repositories;
using CatalogAPI.Entites;
using CatalogAPI.Helpers;
 
public interface IProductRepository
{
    List<Product> GetAll();
    Product GetById(int id);
    bool Create(Product theProduct);
    bool Update(Product producttoUpdate);
    bool Delete(int id); 
}
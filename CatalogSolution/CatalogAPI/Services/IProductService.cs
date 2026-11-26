namespace CatalogAPI.Services;
using CatalogAPI.Entites;
public interface IProductService
{
    
    List<Product> GetAllProducts();
    Product GetProductById(int id);
    bool Intsert(Product product);
    bool Update(Product product);
    bool Delete(int id);
}
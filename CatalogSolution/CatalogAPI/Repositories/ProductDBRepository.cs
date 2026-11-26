namespace CatalogAPI.Repositories;
using CatalogAPI.Entites;
using CatalogAPI.Helpers;
 
public class ProductDBRepository:IProductRepository
{

    string connectionString = @"  ";
    public ProductDBRepository() { }

    public List<Product> GetAll()
    {
        Console.WriteLine("get all method invoked");
        List<Product> allProducts = MySqlDbManager.GetAllProducts();
        return allProducts;
    }

    public Product GetById(int id)
    {
        Product theProduct = MySqlDbManager.GetProductById(id);
        return theProduct;
    }


    public bool Create(Product theProduct)
    {
        bool status = false;
         
        return status;
    }

    public bool Update(Product producttoUpdate)
    {
        bool status = false;
        

        return status;
    }

    public bool Delete(int id)
    {
        bool status = false;
        
        return status;
    }
}
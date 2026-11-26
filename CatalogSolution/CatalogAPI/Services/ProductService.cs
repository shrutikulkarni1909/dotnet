namespace CatalogAPI.Services;
using CatalogAPI.Entites;
using CatalogAPI.Repositories;
public class ProductService : IProductService
{

private IProductRepository _repository;

    public ProductService(IProductRepository repo)
    {
        this._repository=repo;
        
    }
    public bool Delete(int id)
    {

        return this._repository.Delete(id);
    }

    public List<Product> GetAllProducts()
    {
        List<Product> products=new List<Product>();
        products=_repository.GetAll();
        return products;
    }

    public Product GetProductById(int id)
    {
        Product product=new Product();
        this._repository.GetById(id);
        return product;
       
    }

    public bool Intsert(Product product)
    {
        bool status=this._repository.Create(product);
       return false;
    }

    public bool Update(Product product)
    {
        bool status=this._repository.Update(product);
        return false;
    }
}
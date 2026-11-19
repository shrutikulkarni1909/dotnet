using Catalog.Models;

namespace Catalog.Repositories;

public class ProductRepository{

    public List<Product> StockedProducts=new List<Product>();

    public ProductRepository(){

        //Property initializer syntax 

        StockedProducts.Add(new Product { Id = 12, Title = "Gerbera", Description = "Wedding Flower", Price = 5, StockAvailable = 9000 });
        StockedProducts.Add(new Product { Id = 13, Title = "Rose", Description = "Romantic Flower", Price = 10, StockAvailable = 5000 });
        StockedProducts.Add(new Product { Id = 14, Title = "Tulip", Description = "Decorative Flower", Price = 8, StockAvailable = 4000 });
        StockedProducts.Add(new Product { Id = 15, Title = "Lily", Description = "Fragrant Flower", Price = 12, StockAvailable = 3000 });
        StockedProducts.Add(new Product { Id = 16, Title = "Sunflower", Description = "Garden Flower", Price = 7, StockAvailable = 2500 });
        StockedProducts.Add(new Product { Id = 17, Title = "Orchid", Description = "Exotic Flower", Price = 20, StockAvailable = 1500 });
        StockedProducts.Add(new Product { Id = 18, Title = "Daisy", Description = "Spring Flower", Price = 6, StockAvailable = 3500 });
        StockedProducts.Add(new Product { Id = 19, Title = "Marigold", Description = "Festival Flower", Price = 4, StockAvailable = 6000 });
        StockedProducts.Add(new Product { Id = 20, Title = "Carnation", Description = "Bouquet Flower", Price = 9, StockAvailable = 2000 });
        StockedProducts.Add(new Product { Id = 21, Title = "Jasmine", Description = "Traditional Flower", Price = 15, StockAvailable = 1800 });
   }

    public List<Product> GetAll(){
        Console.WriteLine("get all method invoked");

        return StockedProducts;
    }

    public Product GetById(int id){
        List<Product> allProducts=GetAll();
        Product theProduct=null;

        for(int i=0;i<allProducts.Count;i++){
            if(allProducts[i].Id ==id){
                theProduct=allProducts[i];
                return theProduct;
            }
        }
        return theProduct;
    }


    public bool Create(Product theProduct){
        bool status=false;
        this.StockedProducts.Add(theProduct);
        status=true;
        return status;
    }

    public bool Update(Product producttoUpdate)
    {
        int index = StockedProducts.FindIndex(p => p.Id == producttoUpdate.Id);

        if (index != -1)
        {
            StockedProducts[index] = producttoUpdate;
            return true;
        }

        return false;
    }
    

    public bool Delete(int id){
        bool status=false;
        Product existingProduct=GetById(id);
        if(existingProduct!=null){
           StockedProducts.Remove(existingProduct);
           status=true;
        }
        return status;
    }

    

}

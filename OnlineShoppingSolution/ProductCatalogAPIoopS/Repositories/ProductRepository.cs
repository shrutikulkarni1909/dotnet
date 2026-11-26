using Entities;

using  Helpers;
namespace Catalog.Repositories;

public class ProductRepository{

   
   string filePath = @"E:\Projects\dotnet\OnlineShoppingSolution\Data\products.json";
    public ProductRepository(){    }

    public List<Product> GetAll(){
        List<Product> allProducts=PersistManager.Load(filePath);
        return allProducts;
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
        List<Product> allProducts=GetAll();
        allProducts.Add(theProduct);
        PersistManager.Dump(filePath,allProducts);
        status=true;
        return status;
    }

    public bool Update(Product producttoUpdate){
        bool status=false;
        Product existingProduct=GetById(producttoUpdate.Id);
        if(existingProduct!=null){
            existingProduct=producttoUpdate; 
             List<Product> allProducts=GetAll();
             PersistManager.Dump(filePath,allProducts);
            status=true;
        }

        return status;
    }

    public bool Delete(int id){
        bool status=false;
        Product existingProduct=GetById(id);
        if(existingProduct!=null){
            List<Product> allProducts=GetAll();
            allProducts.Remove(existingProduct);
            PersistManager.Dump(filePath,allProducts);
            status=true;
        }
        return status;
    }
}
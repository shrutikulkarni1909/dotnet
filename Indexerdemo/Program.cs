using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{
    public int Id{get; set;}
    public string Name{get; set;}
    public double Price{get; set;}

    public Product(int id, string name, double price){
        Id=id;
        Name=name;
        Price=price;
    }

    public override string ToString()
    {
        return $"{Id} - {Name} - {Price}";
    }
}

public class Catalog{
    private List<Product> products = new List<Product>();

    public Product this[int index]
    {
        get{
            if (index >= 0 && index < products.Count)
                return products[index];
            else
                throw new IndexOutOfRangeException("Invalid product index!");
        }
        set{
            if (index >= 0 && index < products.Count)
                            products[index] = value;
            else
                throw new IndexOutOfRangeException("Invalid product index!");
        }
    }

    public Product this[string name]{
        get{
            return products.FirstOrDefault(p=>p.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
        }
    }

    public void addProduct(Product p){
        products.Add(p);
    }

    public bool removeProduct(int id){
        var product = products.FirstOrDefault(p=> p.Id==id);
        if(product!=null){
            products.Remove(product);
            return true;
        }
        return false;
    }

    public Product SearchByName(string name){
        return products.FirstOrDefault(p=> p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void SortByPrice(bool ascending=true){
        products = ascending ? products.OrderBy(p=>p.Price).ToList() : products.OrderByDescending(p=>p.Price).ToList();
    }

    public void SortByName(){
        products=products.OrderBy(p=>p.Name).ToList();
    }

    public int Count{
        get {return products.Count;}
    }
}

class Program{
    static void Main(){
        Catalog catalog = new Catalog();

        catalog.addProduct(new Product(101, "Laptop", 50000));
        catalog.addProduct(new Product(102, "Mouse", 500));
        catalog.addProduct(new Product(103, "Keyboard", 1500));
        
        Console.WriteLine("Product at index 0:");
        Console.WriteLine(catalog[0]);

        catalog[1] = new Product(104, "Monitor", 12000);

        Console.WriteLine("\nAll Products:");

        for (int i = 0; i < catalog.Count; i++)
        {
            Console.WriteLine(catalog[i]);
        }

        Console.WriteLine("Search by name (Monitor): " + catalog["Monitor"]);

        catalog.SortByPrice(false);

        Console.WriteLine("\nProducts sorted by price (Desc):");
        for (int i = 0; i < catalog.Count; i++)
            Console.WriteLine(catalog[i]);

        catalog.removeProduct(103);
        Console.WriteLine("\nAfter removing Keyboard:");
        for (int i = 0; i < catalog.Count; i++)
            Console.WriteLine(catalog[i]);

    }
}
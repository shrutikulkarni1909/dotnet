using System;

public class Product{
    public int Id;
    public string Name;
    public double Price;

    public Product(int id, string name,double price){
        Id=id;
        Name=name;
        Price=price;
    }
}

class Program{
    static void PrintAllProducts(Product[][] products){
        int rowNumber=1;

        foreach(Product[] row in products){
            Console.WriteLine($"----Category {rowNumber}----");
        

            foreach(Product p in row){
                Console.WriteLine($"Id:{p.Id}, Name: {p.Name}, Price: {p.Price}");
            }
            Console.WriteLine();
            rowNumber++;
        }
    }


static void Main(){
    Product[][] products = new Product[3][]{
        new Product[]{
            new Product(101,"Mouse",500),
            new Product(102,"Keyboard",800),
            new Product(103,"Monitor", 7000)
        },

        new Product[]{
            new Product(104, "Laptop", 55000),
            new Product(105, "Pen Drive", 700),
            new Product(106, "Webcam", 1500),
            new Product(107, "Speaker", 2000)
        },

        new Product[]
        {
            new Product(108, "USB Cable", 300),
            new Product(109, "Charger", 1200)
        }
    };
    PrintAllProducts(products);
}
}

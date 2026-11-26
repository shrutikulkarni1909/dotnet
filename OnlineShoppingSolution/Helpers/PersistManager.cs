namespace Helpers;
using Entities;
using System.Collections.Generic;

using System.Text.Json;

public class PersistManager
{
    public static List<Product> Load(string filePath)
    {
        List<Product> products = new List<Product>();
        if (File.Exists(filePath))
        {
           string json = File.ReadAllText(filePath);
           products = JsonSerializer.Deserialize<List<Product>>(json);
        }
        return products;
    }

    public static bool Dump(string filePath, List<Product> products)
    {

        Boolean status=false;
        try
        { 
            string json=JsonSerializer.Serialize(products,JsonSerializerOptions.Default);
            File.WriteAllText(filePath,json);
            status=true;
        }
        catch(Exception exp)
        {
            
        }
        finally
        {
            
        }
       return status; 
    }
}

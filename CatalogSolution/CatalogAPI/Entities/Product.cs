
using System.ComponentModel.DataAnnotations;

namespace CatalogAPI.Entites;


public class Product
{
    public int Id{get;set;}
    
    [Required]
    public string Title{get;set;}
    
    public int Stock{get;set;}

    [Range(5,15)]
    public int Price{get;set;}
}
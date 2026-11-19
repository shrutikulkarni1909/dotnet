namespace OrderProcess.Models;

public class Order{
    public int OrderId{get; set;}
    public DateTime OrderDate{get; set;}
    public double Amount{get; set;}
    public string CustomerName{get; set;}
}
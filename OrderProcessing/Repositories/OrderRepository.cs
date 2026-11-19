using OrderProcess.Models;
namespace OrderProcess.Repository;

public class OrderRepository{

    public List<Order> Orders = new List<Order>();

    public OrderRepository(){
        Orders.Add(new Order { OrderId = 101, OrderDate = new DateTime(2026, 11, 19), Amount = 2500.50, CustomerName = "Rahul Sharma" });
        Orders.Add(new Order { OrderId = 102, OrderDate = new DateTime(2026, 11, 18), Amount = 1500.00, CustomerName = "Priya Patil" });
        Orders.Add(new Order { OrderId = 103, OrderDate = new DateTime(2026, 11, 17), Amount = 3200.75, CustomerName = "Amit Kulkarni" });
        Orders.Add(new Order { OrderId = 104, OrderDate = new DateTime(2026, 11, 16), Amount = 4500.00, CustomerName = "Sneha Joshi" });
        Orders.Add(new Order { OrderId = 105, OrderDate = new DateTime(2026, 11, 15), Amount = 1800.25, CustomerName = "Rohan Deshmukh" });
        Orders.Add(new Order { OrderId = 106, OrderDate = new DateTime(2026, 11, 14), Amount = 5500.00, CustomerName = "Neha Patil" });
        Orders.Add(new Order { OrderId = 107, OrderDate = new DateTime(2026, 11, 13), Amount = 2750.50, CustomerName = "Karan Joshi" });
        Orders.Add(new Order { OrderId = 108, OrderDate = new DateTime(2026, 11, 12), Amount = 1200.00, CustomerName = "Ananya Shah" });
        Orders.Add(new Order { OrderId = 109, OrderDate = new DateTime(2026, 11, 11), Amount = 3800.75, CustomerName = "Vishal Desai" });
        Orders.Add(new Order { OrderId = 110, OrderDate = new DateTime(2026, 11, 10), Amount = 2100.00, CustomerName = "Meera Kulkarni" });
    }

    public List<Order> GetAll(){
        return Orders;
    }

    public Order GetById(int id){
        List<Order> allOrders= GetAll();
        for(int i=0; i<allOrders.Count; i++){
            if(allOrders[i].OrderId == id)
               return allOrders[i];
        }
        return null;
    }

    public bool Create(Order newOrder){
        bool status=false;
        this.Orders.Add(newOrder);
        status=true;
        return status;
    }

    public bool Update(Order ordertoUpdate){
        bool status = false;
        int index = Orders.FindIndex(p => p.OrderId == ordertoUpdate.OrderId);
        if(index!=-1){
            Orders[index] = ordertoUpdate;
            status=true;
        }
        return status;
    }

    public bool Delete(int id){
        bool status = false;
        Order existingOrder= GetById(id);
        if(existingOrder!=null){
            Orders.Remove(existingOrder);
            status=true;
        }    
        return status;
    }
}
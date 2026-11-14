using EmployeeManagement.Models;

class Program{
    static void Main(){
        Console.WriteLine("-----Manager-----");

        Employee emp = new Manager(20000, 5000, 3000, 4000);
        Console.WriteLine("Salary: "+emp.CalculateSalary());
        Console.WriteLine("Bonus: "+emp.CalculateBonus());

        Console.WriteLine("-----Shadowing-----");
        SalesEmployee sales = new SalesEmployee();
        Console.WriteLine("Child reference: " + sales.CalculateSalary());

        Employee emp2 = new SalesEmployee();
        Console.WriteLine("Parent reference: " + emp2.CalculateSalary());

        Console.WriteLine("\n---- PERSON ----");

        Person p1 = new Person();
        p1.Display();

        Person p2 = new Person("Rahul", "Sharma");
        p2.Display();

        // 4. Sealed class
        Console.WriteLine("\n---- SEALED CLASS ----");

        SecurityToken token = new SecurityToken();
        token.Display();
    
    }
}
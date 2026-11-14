namespace EmployeeManagement.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Default constructor
    public Person()
    {
        FirstName = "Unknown";
        LastName = "Unknown";
    }

    // Parameterized constructor
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}
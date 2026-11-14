using BankingInterfaces.Interfaces;

namespace BankingInterfaces.Models;

public interface IAccountStatement
{
    void ShowDetails();
}

public interface ICustomerStatement
{
    void ShowDetails();
}


public class BankTransaction : IAccountStatement, ICustomerStatement
{
    void IAccountStatement.ShowDetails()
    {
        Console.WriteLine("Showing Account Details");
    }

    void ICustomerStatement.ShowDetails()
    {
        Console.WriteLine("Showing Customer Details");
    }
}
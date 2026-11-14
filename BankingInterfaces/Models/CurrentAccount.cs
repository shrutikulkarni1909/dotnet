using BankingInterfaces.Interfaces;

namespace BankingInterfaces.Models;

public class CurrentAccount : IAccount
{
    private decimal balance;
    private decimal overdraftLimit;

    public CurrentAccount(decimal initialBalance, decimal overdraftLimit)
    {
        balance = initialBalance;
        this.overdraftLimit = overdraftLimit;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance + overdraftLimit)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Overdraft limit exceeded or invalid amount");
        }
    }

    public decimal CheckBalance()
    {
        Console.WriteLine($"Current Account Balance: {balance}");
        return balance;
    }
}
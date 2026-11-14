using BankingInterfaces.Interfaces;

namespace BankingInterfaces.Models;

public class SavingsAccount : IAccount
{
    private decimal balance;

    public SavingsAccount(decimal initialBalance)
    {
        balance = initialBalance;
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
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrawn: {amount}");
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount");
        }
    }

    public decimal CheckBalance()
    {
        Console.WriteLine($"Savings Account Balance: {balance}");
        return balance;
    }

    public void ApplyInterest()
    {
        decimal interest = balance * 0.05m;
        balance += interest;

        Console.WriteLine($"Interest added: {interest}");
    }
}
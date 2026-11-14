using BankingInterfaces.Models;
using BankingInterfaces.Interfaces;
namespace BankingInterfaces.Services;

public class BankingService
{
    public void PerformOperations(IAccount account)
    {
        account.Deposit(2000);
        account.Withdraw(1000);
        account.CheckBalance();
    }
}
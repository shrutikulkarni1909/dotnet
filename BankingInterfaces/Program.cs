using BankingInterfaces.Interfaces;
using BankingInterfaces.Models;
using BankingInterfaces.Services;

class Program
{
    static void Main()
    {
        // 1. Savings Account
        Console.WriteLine("---- SAVINGS ACCOUNT ----");

        SavingsAccount savings = new SavingsAccount(10000);

        savings.Deposit(2000);
        savings.Withdraw(3000);
        savings.ApplyInterest();
        savings.CheckBalance();


        // 2. Current Account
        Console.WriteLine("\n---- CURRENT ACCOUNT ----");

        CurrentAccount current = new CurrentAccount(10000, 5000);

        current.Withdraw(12000);
        current.CheckBalance();


        // 3. Loan Account
        Console.WriteLine("\n---- LOAN ACCOUNT ----");

        LoanAccount loan = new LoanAccount(50000);

        loan.RepayLoan(10000);
        loan.CheckLoanBalance();


        // 4. Banking Service
        Console.WriteLine("\n---- BANKING SERVICE ----");

        BankingService service = new BankingService();

        IAccount account1 = savings;
        IAccount account2 = current;

        service.PerformOperations(account1);

        Console.WriteLine();

        service.PerformOperations(account2);


        // 5. Explicit Interface Implementation
        Console.WriteLine("\n---- BANK TRANSACTION ----");

        BankTransaction transaction = new BankTransaction();

        IAccountStatement accountStatement = transaction;
        ICustomerStatement customerStatement = transaction;

        accountStatement.ShowDetails();
        customerStatement.ShowDetails();
    }
}
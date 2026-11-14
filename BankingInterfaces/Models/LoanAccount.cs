using BankingInterfaces.Interfaces;

namespace BankingInterfaces.Models;

public class LoanAccount
{
    private double loanAmount;

    public LoanAccount(double loanAmount)
    {
        this.loanAmount = loanAmount;
    }

    public void RepayLoan(double amount)
    {
        if (amount > 0 && amount <= loanAmount)
        {
            loanAmount -= amount;
            Console.WriteLine($"Loan repayment: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid repayment amount");
        }
    }

    public void CheckLoanBalance()
    {
        Console.WriteLine($"Remaining Loan: {loanAmount}");
    }
}
public class BankAccount
{
    private decimal balance;

    public void Deposit(decimal amount){
        if(amount>0){
            balance+=amount;
        }
    }

    public decimal GetBalance(){
        return balance;
    }
}

public class Program
{
    static void Main(){
        BankAccount account = new BankAccount();

        account.Deposit(5000);
        account.Deposit(2000);

        Console.WriteLine(account.GetBalance());
    }
}
namespace Banking;

public class Account{
    private string _accountNumber;
    private decimal _balance;

    public Account(string AccountNumber, decimal Balance){
        _accountNumber=AccountNumber;
        _balance=Balance;
    }

    public string AccountNumber => _accountNumber;
    public decimal Balance => _balance;

    public event AccountOperation ? overBalance;
    public event AccountOperation ? underBalance;

    public void Deposit(decimal amount){
        if(amount<=0){
            throw new ArgumentException("Deposit amount must be positive");
        }

        _balance+=amount;
        if(_balance>250000){
            overBalance?.Invoke(this, EventArgs.Empty);
        }
    }

    public void Withdraw(decimal amount){

        if(amount<=0){
            throw new ArgumentException("Withdrawl amount must be positive");
        }
        _balance-=amount;
        if(_balance<10000){
            underBalance?.Invoke(this, EventArgs.Empty);
        }
    }
}
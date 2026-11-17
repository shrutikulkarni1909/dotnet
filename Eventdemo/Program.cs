using Banking;

AccountHandler handler= new AccountHandler();

Account acc = new Account("1234",5000);
acc.overBalance+=handler.PayIncomeTax;
acc.Deposit(300000);
Console.WriteLine($"Account Number: {acc.AccountNumber} ");
Console.WriteLine($"Account Balance: {acc.Balance} ");

Account acc2 = new Account("1235", 10000);
acc2.underBalance+=handler.BlockAccount;
acc2.Withdraw(5000);
Console.WriteLine($"Account Number: {acc2.AccountNumber} ");
Console.WriteLine($"Account Balance: {acc2.Balance} ");



using State.Models;

Console.Title = "State";

var account = new BankAccount();

account.Deposit(100);
account.Withdraw(200);
account.Withdraw(150);
account.Withdraw(250);

account.Deposit(1500);
account.Deposit(100);
account.Withdraw(3000);
using State.Models;

namespace State;

public class RegularState : BankAccountState
{
    public RegularState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"depositing in {GetType()}, amount: {amount}");
        Balance += amount;
        if (Balance > 1000) BankAccount.BankAccountState = new GoldState(Balance, BankAccount);
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"withdrawing in {GetType()}, amount: {amount}");
        Balance -= amount;
        if (Balance < 0 )
        {
            BankAccount.BankAccountState = new OverdrawnState(Balance, BankAccount);
        }
    }
}
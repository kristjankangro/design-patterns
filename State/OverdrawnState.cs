using State.Models;

namespace State;

public class OverdrawnState : BankAccountState
{
    public OverdrawnState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;
    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"depositing in {GetType()}, amount: {amount}");
        Balance += amount;
        if (Balance >= 0)
        {
            BankAccount.BankAccountState = new RegularState(Balance, BankAccount);
        }
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"Withdraw in {GetType()}, cannot withdraw, balance is : {Balance}");
    }
}
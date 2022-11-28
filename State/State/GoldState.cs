using State.Models;

namespace State;

public class GoldState : BankAccountState
{
    public GoldState(decimal balance, BankAccount bankAccount)
    {
        Balance = balance;
        BankAccount = bankAccount;

    }

    public override void Deposit(decimal amount)
    {
        Console.WriteLine($"depositing in {GetType()}, amount: {amount} + 10%");
        Balance += (amount * (decimal)1.1);
    }

    public override void Withdraw(decimal amount)
    {
        Console.WriteLine($"Withdraw in {GetType()}, {Balance}");
        BankAccount.BankAccountState = Balance switch
        {
            < 1000 and >= 0 => new RegularState(Balance, BankAccount),
            < 0 => new OverdrawnState(Balance, BankAccount),
            _ => BankAccount.BankAccountState
        };
    }
}
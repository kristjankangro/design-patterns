using State.Models;

namespace State;

public abstract class BankAccountState
{
    protected BankAccount BankAccount { get; set; } = null!;
    public decimal Balance { get; protected set; }
    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);
}
namespace Decorator.ConcreteComponents;

public class OnPremiseMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Sent message: {message} via {nameof(OnPremiseMailService)}");
        return true;
    }
}
namespace Decorator.ConcreteComponents;

public class CloudMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Sent message: {message}  via {nameof(CloudMailService)}");
        return true;
    }
}
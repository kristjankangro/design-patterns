namespace Decorator;

public interface IMailService
{
    bool SendMail(string message);
}

public class CloudMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"{message} sent via {nameof(CloudMailService)}");
        return true;
    }
}

public class OnPremiseMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"{message} sent via {nameof(OnPremiseMailService)}");
        return true;
    }
}
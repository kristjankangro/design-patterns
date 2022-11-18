using Decorator.Decorator;

namespace Decorator.ConcreteDecorators;

public class StatsDecorator : MailServiceDecoratorBase
{
    public StatsDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"fake stats collecting");
        return base.SendMail(message);
    }
}
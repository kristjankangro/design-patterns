using Decorator.Decorator;

namespace Decorator.ConcreteDecorators;

public class MessageDatabaseDecorator : MailServiceDecoratorBase
{
    public List<string> SenMessages { get; private set; } = new List<string>();

    public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        if (!base.SendMail(message)) return false;
        
        SenMessages.Add(message);
        return true;
    }
}
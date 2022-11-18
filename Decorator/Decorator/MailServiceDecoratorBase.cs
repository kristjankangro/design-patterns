namespace Decorator.Decorator;

public abstract class MailServiceDecoratorBase : IMailService
{

    private readonly IMailService _mailService;

    protected MailServiceDecoratorBase(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}
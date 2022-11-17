namespace Decorator;

public abstract class MailServiceBaseDecorator : IMailService
{
    private readonly IMailService _mailService;

    public MailServiceBaseDecorator(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}

public class StatsDecorator : MailServiceBaseDecorator
{
    public StatsDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"Faking stats collection");
        return base.SendMail( $"{message} via {nameof(StatsDecorator)}");
    }
}

public class DataBaseDecorator : MailServiceBaseDecorator
{
    public List<string> SentMessages { get; private set; } = new List<string>();
    public DataBaseDecorator(IMailService mailService) : base(mailService)
    {
    }
    
    public override bool SendMail(string message)
    {
        if (!base.SendMail( $"{message} via {nameof(DataBaseDecorator)}")) return false;
        
        SentMessages.Add(message);
        return true;
    }
    
    
}
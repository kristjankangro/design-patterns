using TemplateMethod.AbstractClass;

namespace TemplateMethod;

public class ExchangeMailParser : MailParser
{
    public override void AuthServer()
    {
        Console.WriteLine("connecting to exchange server");
    }
}
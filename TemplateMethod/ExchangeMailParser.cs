using TemplateMethod.AbstractClass;

namespace TemplateMethod;

public class ExchangeMailParser : MailParser
{
    protected override void AuthServer()
    {
        Console.WriteLine("connecting to exchange server");
    }
}
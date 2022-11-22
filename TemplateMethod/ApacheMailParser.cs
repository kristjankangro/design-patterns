using TemplateMethod.AbstractClass;

namespace TemplateMethod;

public class ApacheMailParser : MailParser
{
    protected override void AuthServer()
    {
        Console.WriteLine("connecting to Apache server");
    }
}
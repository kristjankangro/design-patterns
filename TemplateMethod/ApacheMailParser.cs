using TemplateMethod.AbstractClass;

namespace TemplateMethod;

public class ApacheMailParser : MailParser
{
    public override void AuthServer()
    {
        Console.WriteLine("connecting to Apache server");
    }
}
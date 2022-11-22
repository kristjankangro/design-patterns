using TemplateMethod.AbstractClass;

namespace TemplateMethod;

public class EudoraMailParser : MailParser
{
    protected override void FindServer()
    {
        Console.WriteLine("finding eudora server with custom algorithm");
    }

    protected override void AuthServer()
    {
        Console.WriteLine("connecting to eudora server");
    }
}
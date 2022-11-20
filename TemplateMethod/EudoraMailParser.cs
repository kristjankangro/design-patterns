using TemplateMethod.AbstractClass;

namespace TemplateMethod;

public class EudoraMailParser : MailParser
{
    public override void FindServer()
    {
        Console.WriteLine("finding eudora server with custom algorithm");
    }

    public override void AuthServer()
    {
        Console.WriteLine("connecting to eudora server");
    }
}
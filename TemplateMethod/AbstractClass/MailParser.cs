﻿namespace TemplateMethod.AbstractClass;

public abstract class MailParser
{
    public virtual void FindServer()
    {
        Console.WriteLine("Finding server ...");
    }

    public abstract void AuthServer();

    private string ParseHtmlMailBody(string code)
    {
        Console.WriteLine("Parsing html mail body");
        return $"body of mail with code: {code}";

    }

    // template method
    public string ParseMailBody(string code)
    {
        Console.WriteLine("parsing body in template method");
        FindServer();
        AuthServer();
        return ParseHtmlMailBody(code);
    }
}
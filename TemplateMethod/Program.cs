using TemplateMethod;

Console.Title = "Template Method";

var exmp = new ExchangeMailParser();
Console.WriteLine(exmp.ParseMailBody("exchange-2wsfe-8efhwj"));
Console.WriteLine();

var amp = new ApacheMailParser();
Console.WriteLine(amp.ParseMailBody("apache-2wsfe-8efhwj"));
Console.WriteLine();

EudoraMailParser emp = new();
Console.WriteLine(emp.ParseMailBody("eudora-2wsfe-8efhwj"));
Console.WriteLine();
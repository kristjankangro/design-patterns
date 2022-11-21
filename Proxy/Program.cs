using Proxy;

Console.Title = "Proxy";

Console.WriteLine("constructing doc ...");
var doc = new Document("doc.pdf");
Console.WriteLine("constructing doc Done");
doc.ShowDocument();

Console.WriteLine();

Console.WriteLine("constructing docproxy...");
var docProxy = new DocumentProxy("doc.pdf");
Console.WriteLine("constructing docProxy Done");
docProxy.ShowDocument();
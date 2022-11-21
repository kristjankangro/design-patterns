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

Console.WriteLine();

Console.WriteLine("constructing protected chained doc proxy...");
var pDocProxy = new ProtectedDocumentProxy("pdoc.pdf", UserRole.Editor);
Console.WriteLine("protected chained doc proxy Done");
pDocProxy.ShowDocument();

Console.WriteLine();

Console.WriteLine("constructing protected chained doc proxy...");
pDocProxy = new ProtectedDocumentProxy("pdoc.pdf", UserRole.Viewer);
Console.WriteLine("protected chained doc proxy Done");
pDocProxy.ShowDocument();

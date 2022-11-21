namespace Proxy;

public class Document : IDocument
{
    public string? Title { get; private set; }
    public string? Content { get; private set; }
    public int AuthorId { get; private set; }
    public DateTimeOffset LastAccessed { get; private set; }
    private string _fileName;

    public Document(string fileName)
    {
        _fileName = fileName;
        LoadDocument(fileName);
    }

    private void LoadDocument(string fileName)
    {
        Console.WriteLine("Executing expensive action");
        Thread.Sleep(1000);
        Title = "Expensive document";
        Content = "a lot content";
        AuthorId = 1;
        LastAccessed = DateTimeOffset.UtcNow;
    }

    public void ShowDocument()
    {
        Console.WriteLine($"{Title} {Content}");
    }
}
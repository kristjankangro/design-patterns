namespace Proxy;

/*public class DocumentProxy : IDocument
{
    // private Document? _document;
    private Document? _document;
    private string _fileName;

    public DocumentProxy(string fileName)
    {
        _fileName = fileName;
    }

    public void ShowDocument()
    {
        //Create document only whne we need it
        _document ??= new Document(_fileName);

        _document.ShowDocument();
    }
}*/

public class DocumentProxy : IDocument
{
    private Lazy<Document> _document;
    private string _fileName;

    public DocumentProxy(string fileName)
    {
        _fileName = fileName;
        _document = new Lazy<Document>(() => new Document(_fileName));
    }

    public void ShowDocument()
    {
        _document.Value.ShowDocument();
    }
}
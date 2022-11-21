namespace Proxy;

public enum UserRole {
    Viewer,
    Editor
}

public class ProtectedDocumentProxy : IDocument
{
    private string _fileName;
    private readonly UserRole _userRole;
    private DocumentProxy _documentProxy;

    public ProtectedDocumentProxy(string fileName, UserRole userRole)
    {
        _fileName = fileName;
        _userRole = userRole;
        _documentProxy = new DocumentProxy(_fileName);
    }

    public void ShowDocument()
    {
        Console.WriteLine($"Entering display document in {nameof(ProtectedDocumentProxy)}");
        if (_userRole == UserRole.Viewer) throw new UnauthorizedAccessException();
        
        _documentProxy.ShowDocument();
        Console.WriteLine($"Exiting display document in {nameof(ProtectedDocumentProxy)}");
    }
}
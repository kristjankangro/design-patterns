using System.ComponentModel.DataAnnotations;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public class DocumentModifiedHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return _successor;
    }

    public void Handle(Document document)
    {
        if (document.LastModified < DateTime.UtcNow.AddDays(-30))
        {
            throw new ValidationException(
                new ValidationResult("Document must be modified in last 30 days", new List<string>() { "LastModified" }), null, null);
        }
        _successor?.Handle(document);
    }
}
using System.ComponentModel.DataAnnotations;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers;

public class DocumentApprovedByManagementHandler : IHandler<Document>
{
    private IHandler<Document>? _successor;

    public IHandler<Document> SetSuccessor(IHandler<Document> successor)
    {
        _successor = successor;
        return _successor;
    }

    public void Handle(Document document)
    {
        if (!document.ApprovedByManagement)
        {
            throw new ValidationException(
                new ValidationResult("Document must be approved by Management", new List<string>() { "ApprovedByLitigation" }), null, null);
        }
        _successor?.Handle(document);
    }
}
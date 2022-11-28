namespace Visitor.Visitor;

public interface IElement
{
    void Accept(IVisitor visitor);
}
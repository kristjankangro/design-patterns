using Visitor.Visitor;

namespace Visitor;

public class Customer : IElement
{
    public decimal AmountOrdered { get; private set; }
    public decimal Discount { get; set; }
    public string Name { get; private set; }

    public Customer(string name, decimal amountOrdered)
    {
        Name = name;
        AmountOrdered = amountOrdered;
    }

    public void Accept(IVisitor visitor)
    {
        visitor.VisitCustomer(this);
        Console.WriteLine($"Accept called visitCustomer discount = {Discount}");
    }
}
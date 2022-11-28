using Visitor.Models;

namespace Visitor.Visitor;

public class DiscountVisitor : IVisitor
{
    public decimal TotalDiscount { get; set; }

    public void VisitCustomer(Customer customer)
    {
        var discount = customer.AmountOrdered / 10;
        customer.Discount = discount;
        TotalDiscount += discount;
    }

    public void VisitEmployee(Employee employee)
    {
        var discount = employee.YearsEmployed < 10 ? 100 : 200;
        employee.Discount = discount;
        TotalDiscount += discount;
    }
}
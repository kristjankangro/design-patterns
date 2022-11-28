using Visitor.Models;

namespace Visitor.Visitor;

public interface IVisitor
{
    void VisitCustomer(Customer customer);
    void VisitEmployee(Employee employee);
}
using Visitor.Models;
using Visitor.Visitor;

namespace Visitor.ObjectStructure;

public class Container
{
    public List<Employee> employees = new List<Employee>();
    public List<Customer> customers = new List<Customer>();

    public void Accept(IVisitor visitor)
    {
        customers.ForEach(customer => customer.Accept(visitor));
        employees.ForEach(employee => employee.Accept(visitor));
    }
}
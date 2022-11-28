using Visitor;
using Visitor.Models;
using Visitor.ObjectStructure;
using Visitor.Visitor;

Console.Title = "Visitor";

var container = new Container();

container.customers.Add(new Customer("Teet", 100));
container.customers.Add(new Customer("Teet2", 157));
container.customers.Add(new Customer("Madis", 200));
container.employees.Add(new Employee("Tiit", 12));
container.employees.Add(new Employee("Teet", 5));

var visitor = new DiscountVisitor();

container.Accept(visitor);

Console.WriteLine($"Total discount given {visitor.TotalDiscount}"); 
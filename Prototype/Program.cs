using Prototype.Abstract.Concrete;

Console.Title = "Prototype";

var manager = new Manager("Cindy");
var managerClone = (Manager) manager.Clone();
Console.WriteLine($"manager was cloned {managerClone.Name}");

var employee = new Employee("Dan", managerClone);
var employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"employee was cloned {employeeClone.Name} with manager {employeeClone.Manager.Name}");

managerClone.Name = "Karen";
Console.WriteLine($"employee was cloned {employeeClone.Name} with manager {employeeClone.Manager.Name}");
Console.WriteLine($"manager name now {managerClone.Name}");
namespace Command.Receiver;

public class EmployeeManagerRepo : IEmployeeManagerRepo
{
    private List<Manager> _managers = new List<Manager>() { new Manager(1, "Karen"), new Manager(2, "Matt") };

    public void AddEmployee(int managerId, Employee employee)
    {
        _managers.First(m => m.Id == managerId).Employees.Add(employee);
    }

    public void RemoveEmployee(int managerId, Employee employee)
    {
        _managers.First(m => m.Id == managerId).Employees.Remove(employee);
    }

    public bool HasEmployee(int managerId, int employeeId)
    {
        return _managers.First(m => m.Id == managerId).Employees.Any(e => e.Id == employeeId);
    }

    public void WriteToRepo()
    {
        foreach (var manager in _managers)
        {
            Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
            if (!manager.Employees.Any())
            {
                Console.WriteLine("    No employees");
                continue;
            }

            foreach (var employee in manager.Employees)
            {
                Console.WriteLine($"    Employee {employee.Id}, {employee.Name}");
            }
        }
    }
}
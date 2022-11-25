namespace Memento.Memento;

public class AddEmployeeToManagerListMemento
{
    public AddEmployeeToManagerListMemento(int managerId, Employee? employee)
    {
        ManagerId = managerId;
        Employee = employee;
    }

    public int ManagerId { get; private set; }
    public Employee? Employee { get; private set; }
}
using Memento;
using Memento.Memento;

public class AddEmployeeToManagerList : ICommand
{
    private readonly IEmployeeManagerRepo _employeeManagerRepo;
    private int _managerId;
    private Employee? _employee;


    public AddEmployeeToManagerList(IEmployeeManagerRepo employeeManagerRepo, int managerId, Employee? employee)
    {
        _employeeManagerRepo = employeeManagerRepo;
        _managerId = managerId;
        _employee = employee;
    }

    public AddEmployeeToManagerListMemento CreateMemento()
    {
        return new AddEmployeeToManagerListMemento(_managerId, _employee);
    }

    public void RestoreMemento( AddEmployeeToManagerListMemento memento)
    {
        _managerId = memento.ManagerId;
        _employee = memento.Employee;
    }

    public void Execute()
    {
        if (_employee != null) _employeeManagerRepo.AddEmployee(_managerId, _employee);
    }

    public void Undo()
    {
        if (_employee != null) _employeeManagerRepo.RemoveEmployee(_managerId, _employee);
    }

    public bool CanExecute()
    {
        return _employee != null && !_employeeManagerRepo.HasEmployee(_managerId, _employee.Id);
    }
}
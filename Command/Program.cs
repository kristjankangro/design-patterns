using Command;
using Command.Command;
using Command.Invoker;
using Command.Receiver;

Console.Title = "Command";

CommandManager commandManager = new ();
IEmployeeManagerRepo repo = new EmployeeManagerRepo();

commandManager.Invoke(new AddEmployeeToManagerList(repo, 1, new Employee(111, "Kevin")));
repo.WriteToRepo();
Console.WriteLine();

commandManager.Undo();
repo.WriteToRepo();
Console.WriteLine();

commandManager.Invoke(new AddEmployeeToManagerList(repo, 1, new Employee(222, "Clara")));
repo.WriteToRepo();
Console.WriteLine();

commandManager.Invoke(new AddEmployeeToManagerList(repo, 2, new Employee(333, "Tom")));
repo.WriteToRepo();
Console.WriteLine();

commandManager.Invoke(new AddEmployeeToManagerList(repo, 2, new Employee(333, "Tom")));
repo.WriteToRepo();
Console.WriteLine();

commandManager.UndoAll();
repo.WriteToRepo();

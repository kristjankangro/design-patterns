namespace Strategy;

public class JsonExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to json");
    }
}
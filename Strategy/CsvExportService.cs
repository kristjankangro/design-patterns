namespace Strategy;

public class CsvExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to csv");
    }
}
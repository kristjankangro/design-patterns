namespace Strategy;

public class XmlExportService : IExportService
{
    public void Export(Order order)
    {
        Console.WriteLine($"Exporting {order.Name} to xml");
    }
}
namespace Strategy;

public class Order
{
    public string Customer { get; set; }
    public int Amount { get; set; }
    public string Name { get; set; }

    public string? Description { get; set; }

    //this porperty is not needed for vaiation method
    public IExportService ExportService { get; set; }

    public Order(string customer, int amount, string name)
    {
        Customer = customer;
        Amount = amount;
        Name = name;
        ExportService = new JsonExportService();
    }

     public void Export()
     {
         ExportService?.Export(this);
     }
    
    public void ExportVariation(IExportService exportService)
    {
        if (exportService is null)
        {
            throw new ArgumentNullException(nameof(exportService));
        }
        Console.WriteLine("using variation method");
        exportService.Export(this);
    }

}
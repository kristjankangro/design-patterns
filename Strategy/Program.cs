using Strategy;

Console.Title = "Strategy";

var order = new Order("Ken", 12, "Watch");
order.Export();

Console.WriteLine("strategy:");
Console.WriteLine();

order.ExportService = new CsvExportService();
order.Export();

order.ExportService = new XmlExportService();
order.Export();

Console.WriteLine();
Console.WriteLine("strategy variation:");
Console.WriteLine();
order.ExportVariation(new JsonExportService());
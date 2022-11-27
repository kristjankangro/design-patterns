using Observer.Observer;
using Observer.Subject;

Console.Title = "Observer";

var stock = new TicketStockService();
var reseller = new TicketResellerService();
var order = new OrderService();

order.AddObserver(stock);
order.AddObserver(reseller);

order.CompleteTicketSale(1, 10);


//stock is empty
order.RemoveObserver(stock);
order.CompleteTicketSale(2, 5);
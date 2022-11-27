using Observer.Helpers;

namespace Observer.Subject;

public class OrderService : TicketChangeNotifier
{
    public void CompleteTicketSale(int artistId, int amount)
    {
        Console.WriteLine($" {nameof(OrderService) } Ticket sale is written to db");
        Console.WriteLine($" {nameof(OrderService) } now notify observers");
        Notifiy(new TicketChange(artistId, amount));
    }
}
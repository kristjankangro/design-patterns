using Observer.Helpers;

namespace Observer.Observer;

public class TicketStockService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        Console.WriteLine($"{nameof(TicketStockService)} notified of ticket change {ticketChange}");
    }
}
using Observer.Helpers;

namespace Observer.Observer;

public class TicketResellerService : ITicketChangeListener
{
    public void ReceiveTicketChangeNotification(TicketChange ticketChange)
    {
        Console.WriteLine($"{nameof(TicketResellerService)} notified of ticket change {ticketChange}");
    }
}
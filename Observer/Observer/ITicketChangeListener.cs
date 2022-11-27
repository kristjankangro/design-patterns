using Observer.Helpers;

namespace Observer.Observer;

public interface ITicketChangeListener
{
    void ReceiveTicketChangeNotification(TicketChange ticketChange);
}
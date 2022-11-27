namespace Observer.Helpers;

public class TicketChange
{
    public TicketChange(int artistId, int amount)
    {
        Amount = amount;
        ArtistId = artistId;
    }

    public int Amount { get; private set; }
    public int ArtistId { get; private set; }

    public override string ToString()
    {
        return $"Artist id: {ArtistId}, amount : {Amount}";
    }
}
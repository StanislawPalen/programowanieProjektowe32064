namespace TicketSystem.Models;

public class Ticket
{
    public int Id { get; private set; }
    public int EventId { get; private set; }
    public decimal Price { get; private set; }

    public Ticket(int id, int eventId, decimal price)
    {
        Id = id;
        EventId = eventId;
        Price = price;
    }

    public override string ToString()
    {
        return $"Bilet #{Id} | Cena: {Price} PLN";
    }
}

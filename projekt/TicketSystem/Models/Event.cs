namespace TicketSystem.Models;

public class Event
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public DateTime Date { get; private set; }
    public int AvailableTickets { get; private set; }

    public Event(int id, string name, DateTime date, int availableTickets)
    {
        Id = id;
        Name = name;
        Date = date;
        AvailableTickets = availableTickets;
    }

    public bool HasAvailableTickets()
    {
        return AvailableTickets > 0;
    }

    public void DecreaseTickets()
    {
        if (AvailableTickets > 0)
        {
            AvailableTickets--;
        }
    }
}

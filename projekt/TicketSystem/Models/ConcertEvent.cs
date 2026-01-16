using System;
using TicketSystem.Models;

namespace TicketSystem.Models;

public class ConcertEvent : Event
{
    public string Artist { get; private set; }

    public ConcertEvent(
        int id,
        string name,
        DateTime date,
        int availableTickets,
        string artist,
        decimal price
    ) : base(id, name, date, availableTickets, price)
    {
        Artist = artist;
    }

    public override string ToString()
    {
        return $"{Name} – koncert ({Artist}), data: {Date:d}";
    }
}

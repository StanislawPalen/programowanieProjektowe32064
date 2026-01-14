using TicketSystem.Models;

namespace TicketSystem.Services;

public class TicketService
{
    public bool TryBuyTicket(Event ev, User user, decimal price)
    {
        if (!ev.HasAvailableTickets())
        {
            return false;
        }

        ev.DecreaseTickets();

        var ticket = new Ticket(
            id: user.Tickets.Count + 1,
            eventId: ev.Id,
            price: price
        );

        user.AddTicket(ticket);
        return true;
    }

    public bool TryRefundTicket(int ticketId, User user, List<Event> events)
    {
        var ticket = user.Tickets.FirstOrDefault(t => t.Id == ticketId);
        if (ticket == null)
        {
            return false;
        }

        var ev = events.FirstOrDefault(e => e.Id == ticket.EventId);
        if (ev == null)
        {
            return false;
        }

        user.Tickets.Remove(ticket);
        ev.IncreaseTickets();

        return true;
    }
}

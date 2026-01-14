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
}

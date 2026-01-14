using System.Collections.Generic;
using TicketSystem.Models;

namespace TicketSystem.Models;

public class User
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public List<Ticket> Tickets { get; private set; }

    public User(int id, string name)
    {
        Id = id;
        Name = name;
        Tickets = new List<Ticket>();
    }

    public void AddTicket(Ticket ticket)
    {
        Tickets.Add(ticket);
    }
}

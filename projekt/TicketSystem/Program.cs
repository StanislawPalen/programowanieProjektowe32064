using TicketSystem.Models;
using TicketSystem.Services;

var dataService = new DataService();
var events = dataService.LoadEvents();

var user = new User(1, "Test User");
var ticketService = new TicketService();

while (true)
{
    Console.WriteLine("\n=== SYSTEM BILETÓW ===");

    if (events.Count == 0)
    {
        Console.WriteLine("Brak dostępnych wydarzeń.");
        break;
    }

    Console.WriteLine("\nDostępne wydarzenia:");
    foreach (var ev in events)
    {
        Console.WriteLine(
            $"{ev.Id}. {ev.Name} | data: {ev.Date:d} | bilety: {ev.AvailableTickets}"
        );
    }

    Console.WriteLine("\nOpcje:");
    Console.WriteLine("1. Kup bilet");
    Console.WriteLine("0. Wyjście");

    Console.Write("Wybór: ");
    var choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.Write("Podaj ID wydarzenia: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out int eventId))
        {
            Console.WriteLine("Nieprawidłowe ID.");
            continue;
        }

        var selectedEvent = events.FirstOrDefault(e => e.Id == eventId);

        if (selectedEvent == null)
        {
            Console.WriteLine("Nie znaleziono wydarzenia o podanym ID.");
            continue;
        }

        var success = ticketService.TryBuyTicket(selectedEvent, user, 50);

        Console.WriteLine(
            success
                ? "Bilet kupiony!"
                : "Brak dostępnych biletów."
        );
    }
    else if (choice == "0")
    {
        break;
    }
}

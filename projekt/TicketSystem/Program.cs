using TicketSystem.Models;
using TicketSystem.Services;

var dataService = new DataService();
var events = dataService.LoadEvents();

var user = new User(1, "Test User");
var ticketService = new TicketService();

// Dane wydarzeń są wczytywane z pliku przy starcie aplikacji.
// Zmiany liczby biletów obowiązują tylko podczas działania programu
// i nie są zapisywane przy ponownym uruchomieniu.

while (true)
{
    Console.WriteLine("\n=== SYSTEM BILETÓW ===");

    Console.WriteLine("\nDostępne wydarzenia:");
    foreach (var ev in events)
{
    Console.WriteLine(
        $"{ev.Id}. {ev.Name} | Data: {ev.Date:yyyy-MM-dd HH:mm} | Cena: {ev.Price} PLN | Dostępne: {ev.AvailableTickets}"
    );
}


    Console.WriteLine("\nOpcje:");
    Console.WriteLine("1. Kup bilet");
    Console.WriteLine("2. Pokaż moje bilety");
    Console.WriteLine("3. Zwróć bilet");
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
            Console.WriteLine("Nie znaleziono wydarzenia.");
            continue;
        }

        var success = ticketService.TryBuyTicket(
    selectedEvent,
    user,
    selectedEvent.Price
);

        Console.WriteLine(success ? "Bilet kupiony!" : "Brak dostępnych biletów.");
    }
    else if (choice == "2")
    {
        Console.WriteLine("\n=== MOJE BILETY ===");

        if (user.Tickets.Count == 0)
        {
            Console.WriteLine("Brak biletów.");
        }
        else
        {
            foreach (var ticket in user.Tickets)
{
    var ev = events.FirstOrDefault(e => e.Id == ticket.EventId);
    var eventName = ev != null ? ev.Name : "Nieznane wydarzenie";

    Console.WriteLine(
        $"Bilet #{ticket.Id} | Wydarzenie: {eventName} | Cena: {ticket.Price} PLN"
    );
}

        }
    }
    else if (choice == "3")
    {
        Console.Write("Podaj ID biletu do zwrotu: ");
        var input = Console.ReadLine();

        if (!int.TryParse(input, out int ticketId))
        {
            Console.WriteLine("Nieprawidłowe ID.");
            continue;
        }

        var success = ticketService.TryRefundTicket(ticketId, user, events);
        Console.WriteLine(
            success
                ? "Bilet został zwrócony."
                : "Nie udało się zwrócić biletu."
        );
    }
    else if (choice == "0")
    {
        break;
    }
}

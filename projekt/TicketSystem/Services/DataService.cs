using System.Text.Json;
using TicketSystem.Models;

namespace TicketSystem.Services;

public class DataService
{
    private const string EventsFile = "events.json";

    public List<Event> LoadEvents()
    {
        if (!File.Exists(EventsFile))
        {
            return new List<Event>();
        }

        var json = File.ReadAllText(EventsFile);
        return JsonSerializer.Deserialize<List<Event>>(json) ?? new List<Event>();
    }
}

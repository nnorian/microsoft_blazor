// EventService.cs
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Data
{
    public class EventService
    {
        private readonly List<EventModel> Events = new()
        {
            new EventModel
            {
                Id = 1,
                EventName = "Programmers Day 2025",
                Location = "Chisinau, Republic of Moldova",
                Attendees = 150
            },
            new EventModel
            {
                Id = 2,
                EventName = "Summer FAF x Sigomid Hackathon 2025",
                Location = "Chisinau, Republic of Moldova",
                Attendees = 5000000
            }
        };

        public IEnumerable<EventModel> GetAllEvents() => Events;
        public EventModel? GetEventById(int id) => Events.FirstOrDefault(e => e.Id == id);
    }
}

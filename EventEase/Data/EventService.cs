// stores and provides event data

namespace EventEase.Data
{
    public class EventService
    {
        private readonly List<EventModel> Events = new()
        {
            new EventModel         {
                Id = 1,
                EventName = "Programmers Day 2025",
                Location = "Chisinau, Republic of Moldova",
                Atendees = 150
            },

            new EventModel
            {
                Id = 2,
                EventName = "Summer FAF x Sigomid Hackathon 2025",
                Location = "Chisinau, Republic of Moldova",
                Atendees = 5000000
            }
        };

        public IEnumerable<EventModel> GetAllEvents() => Events;
        public EventModel? GetEventById(int id) => Events.FirstOrDefault(equals => equals.Id == id);
        public class EventModel
        {
            public int Id { get; set; }
            public string EventName { get; set; } = string.Empty;
            public string Location { get; set; } = string.Empty;
            public int Atendees { get; set; }

        }

    }
}
}
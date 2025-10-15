// EventModel.cs
namespace EventEase.Data
{
    public class EventModel
    {
        public int Id { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int Attendees { get; set; }
    }
}

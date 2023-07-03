namespace EventAgenda.Models.Models.Requests
{
    public class CreateEventRequest
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
namespace EventAgenda.Models.DTOs
{
    public class EventDTO
    {
        public Guid Id { get; set; } = new Guid();
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
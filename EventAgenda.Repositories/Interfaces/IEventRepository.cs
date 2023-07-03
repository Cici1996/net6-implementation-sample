using EventAgenda.Models.DTOs;

namespace EventAgenda.Repositories.Interfaces
{
    public interface IEventRepository
    {
        Task<EventDTO> CreateAsync(EventDTO data);
    }
}
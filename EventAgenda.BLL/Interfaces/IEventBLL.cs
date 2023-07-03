using EventAgenda.Models.DTOs;

namespace EventAgenda.BLL.Interfaces
{
    public interface IEventBLL
    {
        Task<EventDTO> CreateAsync(EventDTO data);
    }
}
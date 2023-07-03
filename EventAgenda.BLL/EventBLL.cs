using EventAgenda.BLL.Interfaces;
using EventAgenda.Models.DTOs;
using EventAgenda.Repositories.Interfaces;

namespace EventAgenda.BLL
{
    public class EventBLL : IEventBLL
    {
        private readonly IEventRepository _repository;

        public EventBLL(IEventRepository repository)
        {
            _repository = repository;
        }

        public async Task<EventDTO> CreateAsync(EventDTO data)
        {
            return await _repository.CreateAsync(data);
        }
    }
}
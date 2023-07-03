using AutoMapper;
using EventAgenda.DataAccess;
using EventAgenda.Models.DTOs;
using EventAgenda.Models.Entities;
using EventAgenda.Repositories.Interfaces;

namespace EventAgenda.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly DatabaseContext _context;
        private readonly IMapper _mapper;

        public EventRepository(DatabaseContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<EventDTO> CreateAsync(EventDTO data)
        {
            var mapData = _mapper.Map<Event>(data);
            var entity = _context.Events.Add(mapData);
            await _context.SaveChangesAsync();
            return _mapper.Map<EventDTO>(entity.Entity);
        }
    }
}
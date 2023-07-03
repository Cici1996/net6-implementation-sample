using AutoMapper;
using EventAgenda.BLL.Interfaces;
using EventAgenda.Models.DTOs;
using EventAgenda.Models.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace EventAgenda.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : EventAgendaBaseController
    {
        private readonly IEventBLL _eventBLL;
        private readonly IMapper _mapper;

        public EventController(IEventBLL eventBLL, IMapper mapper)
        {
            _eventBLL = eventBLL;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody] CreateEventRequest data)
        {
            var map = _mapper.Map<EventDTO>(data);
            var result = await _eventBLL.CreateAsync(map);
            return Ok(result);
        }
    }
}
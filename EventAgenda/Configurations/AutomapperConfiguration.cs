using AutoMapper;
using EventAgenda.Models.DTOs;
using EventAgenda.Models.Entities;
using EventAgenda.Models.Models.Requests;

namespace EventAgenda.Configurations
{
    public class AutomapperConfiguration : Profile
    {
        public AutomapperConfiguration()
        {
            EventMapper();
        }

        public void EventMapper()
        {
            CreateMap<Event, EventDTO>().ReverseMap();
            CreateMap<CreateEventRequest, EventDTO>();
        }
    }
}
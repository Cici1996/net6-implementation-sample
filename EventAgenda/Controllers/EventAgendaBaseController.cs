using EventAgenda.Models.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace EventAgenda.Controllers
{
    public class EventAgendaBaseController : ControllerBase
    {
        public override OkObjectResult Ok([ActionResultObjectValue] object? value)
        {
            return new OkObjectResult(new BaseResponseModel
            {
                Succcess = true,
                Data = value
            });
        }
    }
}

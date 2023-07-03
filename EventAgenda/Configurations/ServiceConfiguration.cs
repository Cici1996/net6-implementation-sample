using EventAgenda.BLL;
using EventAgenda.BLL.Interfaces;
using EventAgenda.Repositories;
using EventAgenda.Repositories.Interfaces;

namespace EventAgenda.Configurations
{
    public static class ServiceConfiguration
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            //BLL
            services.AddScoped<IEventBLL, EventBLL>();

            //REPOSITORY
            services.AddScoped<IEventRepository, EventRepository>();
        }
    }
}
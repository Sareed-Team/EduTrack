using LearningCentre.DAL.IRepository;
using LearningCentre.DAL.Repository;
using LearningCentre.Service.Interfaces;
using LearningCentre.Service.Services;

namespace LearningCentre.Api.Extensions
{
    public static class ServiceExtension
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using MedioClinic.Repositories.Home;
using MedioClinic.Repositories.Doctors;
using MedioClinic.Repositories.Profiles;

namespace MedioClinic.Helpers
{
    public static class IServiceCollectionExtensions
    {
        public static void AddMedioClinicServices(this IServiceCollection services)
        {

            AddRepositories(services);


        }
        private static void AddRepositories(IServiceCollection services)
        {
            
            services.AddSingleton<HomeRepository>();
            services.AddSingleton<DoctorsRepository>();
            services.AddSingleton<ProfileRepository>();
            services.AddHttpContextAccessor();

        }

    }
}

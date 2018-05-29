using LearnMore.BusinessLogic.Managers;
using LearnMore.BusinessLogic.Managers.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMore.Api.DependencyInjection
{
    public static class RegisterManagersExtension
    {
        public static IServiceCollection RegisterManagers(this IServiceCollection services)
        {
            services.AddTransient<IRegistrationManager, RegistrationManager>();
            services.AddTransient<IAuthenticationManager, AuthenticationManager>();

            return services;
        }
    }
}

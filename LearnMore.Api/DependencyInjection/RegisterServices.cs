using LearnMore.Api.JWT;
using LearnMore.BusinessLogic.JWT;
using LearnMore.Data.Services;
using LearnMore.Data.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMore.Api.DependencyInjection
{
    public static class RegisterServicesExtension
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IRegistrationService, RegistrationService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddSingleton<IJwtFactory, JwtFactory>();

            return services;
        }
    }
}
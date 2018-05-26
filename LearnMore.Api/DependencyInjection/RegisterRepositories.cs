using LearnMore.Data.Repositories;
using LearnMore.Data.Repositories.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMore.Api.DependencyInjection
{
    public static class RegisterRepositoriesExtension
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}

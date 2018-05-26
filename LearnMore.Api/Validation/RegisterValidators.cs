using FluentValidation;
using LearnMore.Api.Validation.Validators;
using LearnMore.Domain.Models;
using Microsoft.Extensions.DependencyInjection;

namespace LearnMore.Api.Validation
{
    public static class RegisterValidatorsExtension
    {
        public static IServiceCollection RegisterValidators(this IServiceCollection services)
        {
            services.AddTransient<IValidator<Registration>, RegistrationModelValidator>();

            return services;
        }
    }
}

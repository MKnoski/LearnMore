using LearnMore.Domain.Models;
using System.Threading.Tasks;
using LearnMore.Domain.Models.Registration;

namespace LearnMore.Data.Services.Contracts
{
    public interface IRegistrationService
    {
        Task<Result> CreateUserAsync(Registration registrationModel);
    }
}

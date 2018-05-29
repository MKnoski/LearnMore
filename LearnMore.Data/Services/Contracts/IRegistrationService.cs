using LearnMore.Domain.Models;
using System.Threading.Tasks;

namespace LearnMore.Data.Services.Contracts
{
    public interface IRegistrationService
    {
        Task<Result> CreateUser(Registration registrationModel);
    }
}

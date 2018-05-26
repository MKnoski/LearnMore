using LearnMore.Domain.Models;
using System.Threading.Tasks;

namespace LearnMore.Data.Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<Result> CreateUser(Registration registrationModel);
    }
}

using System.Threading.Tasks;
using LearnMore.Domain.Models;

namespace LearnMore.Data.Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<UserVerification> VerifyUserAsync(Credentials credentials);
    }
}
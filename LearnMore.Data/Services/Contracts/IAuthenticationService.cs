using System.Threading.Tasks;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Authentication;

namespace LearnMore.Data.Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<UserVerification> VerifyUserAsync(Credentials credentials);
    }
}
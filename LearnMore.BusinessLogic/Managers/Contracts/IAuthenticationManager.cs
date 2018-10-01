using System.Threading.Tasks;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Authentication;

namespace LearnMore.BusinessLogic.Managers.Contracts
{
    public interface IAuthenticationManager
    {
        Task<Token> GetTokenAsync(Credentials credentials);
    }
}
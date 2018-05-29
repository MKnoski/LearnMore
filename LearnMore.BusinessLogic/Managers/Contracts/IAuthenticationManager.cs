using System.Threading.Tasks;
using LearnMore.Domain.Models;

namespace LearnMore.BusinessLogic.Managers.Contracts
{
    public interface IAuthenticationManager
    {
        Task<Token> GetTokenAsync(Credentials credentials);
    }
}
using LearnMore.Domain.Models;
using System.Threading.Tasks;

namespace LearnMore.BusinessLogic.Managers.Contracts
{
    public interface IAuthenticationManager
    {
        Task<Result> CreateUser(Registration model);
    }
}
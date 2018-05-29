using LearnMore.Domain.Models;
using System.Threading.Tasks;

namespace LearnMore.BusinessLogic.Managers.Contracts
{
    public interface IRegistrationManager
    {
        Task<Result> CreateUser(Registration model);
    }
}
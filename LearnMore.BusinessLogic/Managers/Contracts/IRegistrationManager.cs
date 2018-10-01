using LearnMore.Domain.Models;
using System.Threading.Tasks;
using LearnMore.Domain.Models.Registration;

namespace LearnMore.BusinessLogic.Managers.Contracts
{
    public interface IRegistrationManager
    {
        Task<Result> CreateUser(Registration model);
    }
}
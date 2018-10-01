using System.Threading.Tasks;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Registration;

namespace LearnMore.Data.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<Result> AddUserAsync(string id, Registration model);
    }
}
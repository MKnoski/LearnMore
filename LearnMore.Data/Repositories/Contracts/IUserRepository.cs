using System.Threading.Tasks;
using LearnMore.Domain.Models;

namespace LearnMore.Data.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task<Result> AddUser(string id, Registration model);
    }
}
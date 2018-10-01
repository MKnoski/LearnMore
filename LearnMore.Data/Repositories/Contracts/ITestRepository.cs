using System.Threading.Tasks;
using LearnMore.Data.Entities;
using LearnMore.Domain.Models;

namespace LearnMore.Data.Repositories.Contracts
{
    public interface ITestRepository
    {
        Task<Result> AddTestAsync(TestEntity model);
    }
}
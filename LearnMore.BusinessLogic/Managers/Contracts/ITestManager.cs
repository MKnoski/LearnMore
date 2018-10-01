using System.Threading.Tasks;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Test;

namespace LearnMore.BusinessLogic.Managers.Contracts
{
    public interface ITestManager
    {
        Task<Result> CreateNewTestAsync(Test test);
    }
}
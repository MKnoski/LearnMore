using System.Threading.Tasks;
using AutoMapper;
using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Data.Entities;
using LearnMore.Data.Repositories.Contracts;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Test;

namespace LearnMore.BusinessLogic.Managers
{
    public class TestManager : ITestManager
    {
        private readonly IMapper mapper;
        private readonly ITestRepository testRepository;

        public TestManager(IMapper mapper, ITestRepository testRepository)
        {
            this.mapper = mapper;
            this.testRepository = testRepository;
        }

        public async Task<Result> CreateNewTestAsync(Test test)
        {
            var newTest = this.mapper.Map<TestEntity>(test);

            var result = await this.testRepository.AddTestAsync(newTest);

            return result;
        }
    }
}
using System.Threading.Tasks;
using LearnMore.Data.Context;
using LearnMore.Data.Entities;
using LearnMore.Data.Repositories.Contracts;
using LearnMore.Domain.Models;

namespace LearnMore.Data.Repositories
{
    public class TestRepository : ITestRepository
    {
        private readonly AppDbContext appDbContext;

        public TestRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public async Task<Result> AddTestAsync(TestEntity model)
        {
            await this.appDbContext.Tests.AddAsync(model);
            var result = await this.appDbContext.SaveChangesAsync();

            return new Result(result == 1);
        }
    }
}
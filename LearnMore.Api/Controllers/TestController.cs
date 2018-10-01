using System.Threading.Tasks;
using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Domain.Models.Test;
using Microsoft.AspNetCore.Mvc;

namespace LearnMore.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class TestController : BaseController
    {
        private readonly ITestManager testManager;

        public TestController(ITestManager testManager)
        {
            this.testManager = testManager;
        }

        // POST api/test
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Test test)
        {
            var result = await this.testManager.CreateNewTestAsync(test);

            return base.HandleResult(result);
        }
    }
}
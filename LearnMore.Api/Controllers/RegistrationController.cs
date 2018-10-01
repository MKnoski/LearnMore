using System.Threading.Tasks;
using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Domain.Models.Registration;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LearnMore.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Registration")]
    public class RegistrationController : BaseController
    {
        private readonly IRegistrationManager registrationManager;
        private readonly ILogger<RegistrationController> logger;

        public RegistrationController(IRegistrationManager registrationManager, ILogger<RegistrationController> logger)
        {
            this.registrationManager = registrationManager;
            this.logger = logger;
        }

        // POST api/Registration
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Registration model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await this.registrationManager.CreateUser(model);

            return base.HandleResult(result);
        }
    }
}
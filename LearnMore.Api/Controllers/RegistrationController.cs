using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Domain.Enums;
using LearnMore.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LearnMore.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Registration")]
    public class RegistrationController : Controller
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

            if (result.Status == ResultStatus.Failed)
            {
                return StatusCode(409, result.Message);
            }

            return Ok();
        }
    }
}
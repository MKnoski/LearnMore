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
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationManager authenticationManager;
        private readonly ILogger<AuthenticationController> logger;

        public AuthenticationController(IAuthenticationManager authenticationManager, ILogger<AuthenticationController> logger)
        {
            this.authenticationManager = authenticationManager;
            this.logger = logger;
        }

        // POST api/Authentication
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Registration model)
        {
            this.logger.LogInformation("First Test");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await this.authenticationManager.CreateUser(model);

            if (result.Status == ResultStatus.Failed)
            {
                return StatusCode(409, result.Message);
            }

            return Ok();
        }
    }
}
using System.Threading.Tasks;
using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnMore.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Authentication")]
    public class AuthenticationController : Controller
    {
        private readonly IAuthenticationManager authenticationManager;

        public AuthenticationController(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }

        // POST api/Authentication/login
        [HttpPost("login")]
        public async Task<IActionResult> Post([FromBody]Credentials credentials)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var token = await this.authenticationManager.GetTokenAsync(credentials);

            if (token == null)
            {
                return BadRequest("Login Failure");
            }

            return new OkObjectResult(token);
        }
    }
}
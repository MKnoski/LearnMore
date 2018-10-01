using Microsoft.AspNetCore.Mvc;

namespace LearnMore.Api.Controllers
{
    [Produces("application/json")]
    [Route("api")]
    public class HomeController : BaseController
    {
        // GET api
        [HttpGet]
        public string Get()
        {
            return "Welcome to LearnMore API! Everything works correctly";
        }
    }
}
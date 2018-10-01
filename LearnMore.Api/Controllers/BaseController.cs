using LearnMore.Domain.Enums;
using LearnMore.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LearnMore.Api.Controllers
{
    public abstract class BaseController : Controller
    {
        protected IActionResult HandleResult(Result result)
        {
            if (result.Status == ResultStatus.Failed)
            {
                return StatusCode(409, result.Message);
            }

            return Ok();
        }
    }
}
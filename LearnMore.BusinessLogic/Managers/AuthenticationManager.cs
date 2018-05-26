using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Data.Services.Contracts;
using LearnMore.Domain.Models;
using System.Threading.Tasks;

namespace LearnMore.BusinessLogic.Managers
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IAuthenticationService authenticationService;

        public AuthenticationManager(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        public Task<Result> CreateUser(Registration model)
        {
            var result = this.authenticationService.CreateUser(model);

            return result;
        }
    }
}
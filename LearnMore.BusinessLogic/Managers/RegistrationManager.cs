using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Data.Services.Contracts;
using LearnMore.Domain.Models;
using System.Threading.Tasks;

namespace LearnMore.BusinessLogic.Managers
{
    public class RegistrationManager : IRegistrationManager
    {
        private readonly IRegistrationService registrationService;

        public RegistrationManager(IRegistrationService registrationService)
        {
            this.registrationService = registrationService;
        }

        public Task<Result> CreateUser(Registration model)
        {
            var result = this.registrationService.CreateUser(model);

            return result;
        }
    }
}
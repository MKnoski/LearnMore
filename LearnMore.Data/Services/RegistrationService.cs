using AutoMapper;
using LearnMore.Data.Entities;
using LearnMore.Data.Repositories.Contracts;
using LearnMore.Data.Services.Contracts;
using LearnMore.Domain.Enums;
using LearnMore.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearnMore.Domain.Models.Registration;

namespace LearnMore.Data.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly UserManager<AppUserEntity> userManager;
        private readonly IMapper mapper;
        private readonly IUserRepository userRepository;
        private readonly ILogger<RegistrationService> logger;

        public RegistrationService(UserManager<AppUserEntity> userManager, IMapper mapper, IUserRepository userRepository, ILogger<RegistrationService> logger)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.userRepository = userRepository;
            this.logger = logger;
        }

        public async Task<Result> CreateUserAsync(Registration registrationModel)
        {
            var userIdentity = mapper.Map<AppUserEntity>(registrationModel);

            var identityResult = await userManager.CreateAsync(userIdentity, registrationModel.Password);

            if (!identityResult.Succeeded)
            {
                this.LogErrors(identityResult.Errors);
                return new Result(ResultStatus.Failed, String.Join(" ", identityResult.Errors.Select(s => s.Description)));
            }

            var result = await userRepository.AddUserAsync(userIdentity.Id, registrationModel);
            return result;
        }

        private void LogErrors(IEnumerable<IdentityError> errors)
        {
            errors.ToList().ForEach(x => logger.LogInformation($"{x.Code} {x.Description}\n"));
        }
    }
}

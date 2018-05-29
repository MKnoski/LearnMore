using System.Threading.Tasks;
using LearnMore.Data.Entities;
using LearnMore.Data.Services.Contracts;
using LearnMore.Domain.Models;
using Microsoft.AspNetCore.Identity;

namespace LearnMore.Data.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<AppUser> userManager;

        public AuthenticationService(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<UserVerification> VerifyUserAsync(Credentials credentials)
        {
            var user = await userManager.FindByNameAsync(credentials.UserName);
            if (user == null)
            {
                return new UserVerification(false);
            }

            var isVerified = await userManager.CheckPasswordAsync(user, credentials.Password);

            return new UserVerification(isVerified, user.Id);
        }
    }
}
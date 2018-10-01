using System.Linq;
using System.Threading.Tasks;
using LearnMore.Api.JWT;
using LearnMore.BusinessLogic.JWT;
using LearnMore.BusinessLogic.Managers.Contracts;
using LearnMore.Data.Services.Contracts;
using LearnMore.Domain.Models;
using LearnMore.Domain.Models.Authentication;
using Microsoft.Extensions.Options;

namespace LearnMore.BusinessLogic.Managers
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IJwtFactory jwtFactory;
        private readonly JwtIssuerOptions jwtOptions;
        private readonly IAuthenticationService authenticationService;

        public AuthenticationManager(IJwtFactory jwtFactory, IOptions<JwtIssuerOptions> jwtOptions, IAuthenticationService authenticationService)
        {
            this.jwtFactory = jwtFactory;
            this.jwtOptions = jwtOptions.Value;
            this.authenticationService = authenticationService;
        }

        public async Task<Token> GetTokenAsync(Credentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.Email) || string.IsNullOrEmpty(credentials.Password))
            {
                return null;
            }

            var userVerification = await authenticationService.VerifyUserAsync(credentials);

            if (userVerification.IsVerified)
            {
                var identity = jwtFactory.GenerateClaimsIdentity(credentials.Email, userVerification.Id);

                var token = new Token
                {
                    Id = identity.Claims.Single(c => c.Type == "id").Value,
                    AuthToken = await jwtFactory.GenerateEncodedTokenAsync(credentials.Email, identity),
                    ExpiresIn = (int)jwtOptions.ValidFor.TotalSeconds
                };

                return token;
            }

            return null;
        }
    }
}
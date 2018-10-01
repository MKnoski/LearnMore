using System.Security.Claims;
using System.Threading.Tasks;

namespace LearnMore.Api.JWT
{
    public interface IJwtFactory
    {
        Task<string> GenerateEncodedTokenAsync(string userName, ClaimsIdentity identity);
        ClaimsIdentity GenerateClaimsIdentity(string userName, string id);
    }
}
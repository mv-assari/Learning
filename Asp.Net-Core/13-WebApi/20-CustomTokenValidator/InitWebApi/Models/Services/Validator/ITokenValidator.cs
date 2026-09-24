using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InitWebApi.Models.Services.Validator
{
    public interface ITokenValidator
    {
        Task Execute(TokenValidatedContext context);
    }

    public class TokenValidator : ITokenValidator
    {
        private readonly UserRepository _userRepository;

        public TokenValidator(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Execute(TokenValidatedContext context)
        {
            var claimIdentity = context.Principal.Identity as ClaimsIdentity;
            if (claimIdentity?.Claims == null || !claimIdentity.Claims.Any())
            {
                context.Fail("Claim not found ... ");
                return;
            }

            var userId = claimIdentity.FindFirst("UserId").Value;
            if (!Guid.TryParse(userId,out Guid userGuid))
            {
                context.Fail("Claim not found ... ");
                return;
            }

            var user = _userRepository.GetUser(userGuid);
            if (user.IsActive==false)
            {
                context.Fail("User Not Active");
                return;
            }

        }
    }
}

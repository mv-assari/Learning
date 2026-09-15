using Microsoft.AspNetCore.Authorization;
using System.Threading.Tasks;

namespace RunIdentity.Helper
{
    public class UserCrediteRequerment:IAuthorizationRequirement
    {
        public int Credit {  get; set; }

        public UserCrediteRequerment(int credit)
        {
            Credit = credit;
        }
    }

    public class UserCreditHandler : AuthorizationHandler<UserCrediteRequerment>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, UserCrediteRequerment requirement)
        {
            var claim = context.User.FindFirst("Credit");
            if (claim != null)
            {
                int credit=int.Parse(claim?.Value);
                if (credit >= requirement.Credit)
                {
                    context.Succeed(requirement);
                }
            }
            return Task.CompletedTask;
        }
    }
}

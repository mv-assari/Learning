using Microsoft.AspNetCore.Authorization;
using RunIdentity.Models.Dto;
using System.Threading.Tasks;

namespace RunIdentity.Helper
{
    public class BlogRequirement:IAuthorizationRequirement
    {

    }

    public class IsBlogForUser : AuthorizationHandler<BlogRequirement, BlogDto>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, BlogRequirement requirement, BlogDto resource)
        {
            if(context.User.Identity?.Name == resource.UserName)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}

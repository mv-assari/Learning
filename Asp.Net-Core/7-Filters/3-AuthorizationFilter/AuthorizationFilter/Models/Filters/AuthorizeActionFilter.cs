using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Security.Claims;

namespace AuthorizationFilter.Models.Filters
{
    public class AuthorizeActionFilter :Attribute, IAuthorizationFilter
    {
        private readonly string _role;

        public AuthorizeActionFilter(string role)
        {
            _role = role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var isAuthorized=CheckUserPermision(context.HttpContext.User,_role);
            if (!isAuthorized)
            {
                context.Result = new UnauthorizedResult();
            }
        }

        private bool CheckUserPermision(ClaimsPrincipal user,string role)
        {
            if (role == "Admin")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

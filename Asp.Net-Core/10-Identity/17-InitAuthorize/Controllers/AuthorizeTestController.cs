using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RunIdentity.Controllers
{
    [Authorize]//فقط کاربرانی که لاگین کرده اند به این کنترلر دسترسی دارند
    public class AuthorizeTestController : Controller
    {
        [AllowAnonymous]//همه کاربران به این اکشن دسترسی دارند
        public string Index()
        {
            return "Index" ;
        }

        [Authorize(Roles ="Operator,Admin")] //فقط کاربرانی که لاگین کرده اند به این اکشن دسترسی دارند
        public string Edit()
        {
            return "Index";
        }
    }
}

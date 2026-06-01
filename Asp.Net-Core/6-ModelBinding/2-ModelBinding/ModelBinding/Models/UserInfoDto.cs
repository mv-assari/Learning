using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ModelBinding.Models
{
    public class UserInfoDto
    {
        [BindNever]//دیگه این پراپرتی توسط کاربر دریافت نمیشه و بایند نمیشه
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [FromHeader]//توکن رو فقط داخل هدر دنبالش میگرده و در همونجاهم انتظار داره باشه
        public string Token { get; set; }
    }
}

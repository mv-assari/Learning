using Microsoft.AspNetCore.Identity;
using RunIdentity.Models.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RunIdentity.Helper
{
    public class MyPasswordValidator : IPasswordValidator<User>
    {
        List<string> commonPassword = new List<string>()
        {
            "123","1234","12345689"
        };
        public Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user, string password)
        {
            if (commonPassword.Contains(password))
            {
                var result = IdentityResult.Failed(new IdentityError
                {
                    Code = "CommonPassword",
                    Description = "این پسورد ضعیف هست کلمه عبور پیچیده تری انتخاب کنید"
                });
                return Task.FromResult(result);
            }
            return Task.FromResult(IdentityResult.Success);
        }
    }
}

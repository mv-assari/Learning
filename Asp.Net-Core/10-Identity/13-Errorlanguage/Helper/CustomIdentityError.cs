using Microsoft.AspNetCore.Identity;

namespace RunIdentity.Helper
{
    public class CustomIdentityError:IdentityErrorDescriber //بقیه خطاها در این کلاس هست که باید بازنویسی شوند
    {
        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = "خطای نامشحض"
            };
        }

        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = "کلمه عبور باید حداقل یک عدد داشته باشد"
            };
        }

        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = "کلمه عبور و تکرار آن باهم یکسان نیست"
            };
        }


    }
}

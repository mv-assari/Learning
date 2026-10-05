using System.ComponentModel.DataAnnotations;

namespace WebSite.EndPoint.Models.ViewModels.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="ایمیل خود را وارد کنید")]
        [EmailAddress]
        [Display(Name ="ایمیل")]
        public string Email { get; set; }


        [Required(ErrorMessage ="پسورد خود را وارد کنید")]
        [DataType(DataType.Password)]
        [Display(Name ="پسورد")]
        public string Password { get; set; }

        [Display(Name ="Remember Me")]
        public bool IsPersistent { get; set; }

        public string ReturnUrl { get; set; }
    }
}

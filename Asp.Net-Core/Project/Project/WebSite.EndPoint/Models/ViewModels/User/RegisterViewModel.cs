using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebSite.EndPoint.Models.ViewModels.Register
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="نام و نام خانوادگی را وارد نمایید")]
        [Display(Name ="نام و نام خانوادگی")]
        [MaxLength(100,ErrorMessage ="نام و نام خانوادگی نباید بیشتر از 100 کاراکتر باشد")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="ایمیل را وارد کنید")]
        [EmailAddress]
        [Display(Name ="ایمیل")]
        public string Email { get; set; }

        [Required(ErrorMessage ="پسورد را وارد کنید")]
        [DataType(DataType.Password)]
        [Display(Name ="پسورد")]
        public string Password { get; set; }

        [Required(ErrorMessage ="تکرار پسورد را وارد کنید")]
        [DataType(DataType.Password)]
        [Display(Name ="تکرار پسورد")]
        [Compare(nameof(Password),ErrorMessage ="پسورد و تکرار آن باید برابر باشد")]
        public string RePassword { get; set; }

        public string PhoneNumber { get; set; }
    }
}

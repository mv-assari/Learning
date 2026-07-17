using System.ComponentModel.DataAnnotations;

namespace RunIdentity.Models.Dto
{
    public class RegisterDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))] //باعث میشه به صورت خودکار عمل مقایسه رو با پسورد انجام بده
        public string ConfirmPassword { get; set; }
    }
}

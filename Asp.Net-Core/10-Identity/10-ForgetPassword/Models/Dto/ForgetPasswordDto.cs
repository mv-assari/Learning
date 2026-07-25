using System.ComponentModel.DataAnnotations;

namespace RunIdentity.Models.Dto
{
    public class ForgetPasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

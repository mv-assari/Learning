using System.ComponentModel.DataAnnotations;

namespace RunIdentity.Models.Dto
{
    public class PhoneNumberDto
    {
        [Required]
        [RegularExpression(@"(\+98|0)?9\d{9}")]
        public string PhoneNumber { get; set; }
    }
}

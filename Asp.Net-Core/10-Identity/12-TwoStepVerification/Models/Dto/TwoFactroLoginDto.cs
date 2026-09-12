using System.ComponentModel.DataAnnotations;

namespace RunIdentity.Models.Dto
{
    public class TwoFactroLoginDto
    {
        [Required]
        public string Code { get; set; }
        public bool IsPersistent { get; set; }
        public string Provider { get; set; }
    }
}

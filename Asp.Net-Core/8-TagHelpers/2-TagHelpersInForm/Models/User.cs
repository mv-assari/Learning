using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InitTagHelpers.Models
{
    public class User
    {
        [DisplayName("نام")]
        public string FirstName { get; set; }

        [DisplayName("نام خانوادگی")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Gender { get; set; }

        [Range(12,100)]
        public byte Age { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Url)]
        public string WebSite { get; set; }

        public Address Address { get; set; }

        [MinLength(10)]
        [MaxLength(100)]
        public string Description { get; set; }
    }


    public class Address
    {
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }
    }
}

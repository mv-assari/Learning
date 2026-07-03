using Microsoft.AspNetCore.Identity;

namespace RunIdentity.Models.Entities
{
    public class Role:IdentityRole
    {
        public string Description { get; set; }
    }
}

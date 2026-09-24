using System;
using System.Collections.Generic;

namespace InitWebApi.Models.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; } = true;
        public ICollection<UserToken> UserTokens { get; set; }
    }
}

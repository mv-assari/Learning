using System;

namespace InitWebApi.Models.Entities
{
    public class UserToken
    {
        public int Id { get; set; }
        public string TokenHash { get; set; }
        public DateTime TokenExp { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExp { get; set; }
        public string MobileModel { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}

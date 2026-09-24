using InitWebApi.Models.Context;
using InitWebApi.Models.Entities;

namespace InitWebApi.Models.Services
{
    public class UserTokenRepository
    {
        private readonly DataBaseContext _context;

        public UserTokenRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void SaveToken(UserToken userToken)
        {
            _context.UserTokens.Add(userToken);
            _context.SaveChanges();
        }
    }
}

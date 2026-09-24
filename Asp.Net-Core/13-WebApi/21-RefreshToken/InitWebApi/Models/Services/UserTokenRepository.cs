using InitWebApi.Models.Context;
using InitWebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

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

        public UserToken FindRefreshToken(string refreshToken)
        {
            var userToken= _context.UserTokens.Include(p=>p.User).FirstOrDefault(p=>p.RefreshToken== refreshToken);
            return userToken;
        }

        public void DeleteToken(string refreshToken)
        {
            var token = FindRefreshToken(refreshToken);
            if(token != null)
            {
                _context.UserTokens.Remove(token);
                _context.SaveChanges();
            }
        }
    }
}

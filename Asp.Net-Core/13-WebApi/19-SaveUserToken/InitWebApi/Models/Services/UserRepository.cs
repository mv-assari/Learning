using InitWebApi.Models.Context;
using InitWebApi.Models.Entities;
using System;
using System.Linq;

namespace InitWebApi.Models.Services
{
    public class UserRepository
    {
        private readonly DataBaseContext _context;

        public UserRepository(DataBaseContext context)
        {
            _context = context;
        }

        public User GetUser(Guid id)
        {
            var user = _context.Users.Find(id);
            return user;
        }

        public bool ValidateUser(string userName, string password) 
        {
            var user = _context.Users.FirstOrDefault();
            return user != null ? true : false;
        }
    }
}

using InitWebApi.Models.Context;
using InitWebApi.Models.Entities;
using InitWebApi.Models.Entities.Dtos;
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

        public string GetCode(string phoneNumber)
        {
            Random rand = new Random();
            string code = rand.Next(1000, 9999).ToString();
            SmsCode smsCode = new SmsCode()
            {
                Code = code,
                PhoneNumber = phoneNumber,
                RequestCount = 0,
                InsertDate = DateTime.Now,
                Used = false
            };

            _context.SmsCodes.Add(smsCode);
            _context.SaveChanges();

            return code;
        }


        public LoginDto Login(string phoneNumber,string Code)
        {
            var smsCode=_context.SmsCodes.Where(p=>p.PhoneNumber == phoneNumber && p.Code==Code).FirstOrDefault();
            if (smsCode == null)
            {
                return new LoginDto
                {
                    IsSuccess = false,
                    Message = "Incorrect Code",
                    User = null
                };
            }

            else
            {                
                if (smsCode.Used==true)
                {
                    return new LoginDto
                    {
                        IsSuccess = false,
                        Message = "Is Used Code",
                        User = null
                    };
                }
                smsCode.Used = true;
                smsCode.RequestCount++;

                _context.SaveChanges();
                var user=FindUserByPhoneNumber(phoneNumber);
                if (user != null)
                {
                    return new LoginDto
                    {
                        IsSuccess = true,
                        User = user,
                    };
                }
                else
                {
                    user=RegisterUser(phoneNumber);
                    return new LoginDto
                    {
                        IsSuccess = true,
                        User = user,
                    };
                }
            }
        }

        public User RegisterUser(string phoneNumber)
        {
            User user = new User()
            {
                PhoneNumber = phoneNumber,
                IsActive = true,
            };

            return user;
        }

        public User FindUserByPhoneNumber(string phoneNumber)
        {
            var user=_context.Users.FirstOrDefault(p=>p.PhoneNumber == phoneNumber);
            return user;
        }
    }
}

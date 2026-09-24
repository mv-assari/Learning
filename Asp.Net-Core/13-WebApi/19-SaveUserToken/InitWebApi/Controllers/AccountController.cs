using InitWebApi.Models.Entities;
using InitWebApi.Models.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace InitWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly UserRepository _userRepository;
        private readonly UserTokenRepository _userTokenRepository;

        public AccountController(IConfiguration configuration, UserRepository userRepository, UserTokenRepository userTokenRepository)
        {
            _configuration = configuration;
            _userRepository = userRepository;
            _userTokenRepository = userTokenRepository;
        }

        [HttpPost]
        public IActionResult Post(string userName,string password)
        {
            if (_userRepository.ValidateUser(userName,password))
            {

                var user = _userRepository.GetUser(Guid.Parse("e1bd67f0-3c2b-49bf-9a50-ba09a6847c93"));

                var claims = new List<Claim>
                {
                    new Claim("UserId",user.Id.ToString()),
                    new Claim("Name",user.Name),
                };

                string key = _configuration["JWTConfig:key"];
                var secretKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                var credentials=new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256);
                var tokenExp = DateTime.Now.AddMinutes(int.Parse(_configuration["JWTConfig:expires"]));
                var token = new JwtSecurityToken(issuer: _configuration["JWTConfig:issuer"], //چه کسی ایجاد کرده
                                                 audience: _configuration["JWTConfig:audience"], // چه کسی استفاده میکنه
                                                 expires: tokenExp, // چند وقت اعتبار داره
                                                 notBefore:DateTime.Now.AddMinutes(1),//از کی اعتبارش شروع بشه
                                                 claims:claims,
                                                 signingCredentials:credentials);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                _userTokenRepository.SaveToken(new UserToken
                {
                    MobileModel="LG V20",
                    TokenExp=tokenExp,
                    TokenHash=jwtToken, //بهتر هست توکن، رمزنگاری شود تا سمت کاربر محفوظ بماند
                    User=user,
                });
                return Ok(jwtToken);
            }

            else
            {
                return Unauthorized();
            }
        }
    }
}

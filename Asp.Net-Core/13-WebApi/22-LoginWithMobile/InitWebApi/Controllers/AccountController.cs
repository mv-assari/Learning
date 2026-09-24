using InitWebApi.Models.Entities;
using InitWebApi.Models.Entities.Dtos;
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
        public IActionResult Post(string phoneNumber,string smsCode)
        {
            var loginResult=_userRepository.Login(phoneNumber, smsCode);
            if (loginResult.IsSuccess==false)
            {
                return Unauthorized(new LoginResultDto
                {
                    IsSuccess = false,
                    Message=loginResult.Message
                });
            }

            var token=CreateToken(loginResult.User);
            return Ok(new LoginResultDto
            {
                IsSuccess=true,
                Data=token
            });
        }

        [HttpPost]
        [Route("RefreshToken")]
        public IActionResult RefreshToken(string refreshToken)
        {
            var userToken=_userTokenRepository.FindRefreshToken(refreshToken);
            if (userToken == null)
            {
                return Unauthorized();
            }

            if (userToken.RefreshTokenExp<DateTime.Now)
            {
                return Unauthorized("Token Expire");
            }
            var token = CreateToken(userToken.User);
            _userTokenRepository.DeleteToken(refreshToken);
            return Ok(token);
        }

        [HttpGet]
        [Route("GetSmsCode")]
        public IActionResult GetSmsCode(string phoneNumber)
        {
            var smsCode=_userRepository.GetCode(phoneNumber);
            // ارسال کد به موبایل کاربر
            return Ok();
        }

        private LoginDataDto CreateToken(User user)
        {

                var claims = new List<Claim>
                {
                    new Claim("UserId",user.Id.ToString()),
                    new Claim("Name",user?.Name??""),
                };

                string key = _configuration["JWTConfig:key"];
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                var credentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokenExp = DateTime.Now.AddMinutes(int.Parse(_configuration["JWTConfig:expires"]));
                var token = new JwtSecurityToken(issuer: _configuration["JWTConfig:issuer"], //چه کسی ایجاد کرده
                                                 audience: _configuration["JWTConfig:audience"], // چه کسی استفاده میکنه
                                                 expires: tokenExp, // چند وقت اعتبار داره
                                                 notBefore: DateTime.Now.AddMinutes(1),//از کی اعتبارش شروع بشه
                                                 claims: claims,
                                                 signingCredentials: credentials);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);
                var refreshToken=Guid.NewGuid().ToString();


                _userTokenRepository.SaveToken(new UserToken
                {
                    MobileModel = "LG V20",
                    TokenExp = tokenExp,
                    TokenHash = jwtToken, //بهتر هست توکن، رمزنگاری شود تا سمت کاربر محفوظ بماند
                    User = user,
                    RefreshToken = refreshToken,
                    RefreshTokenExp = DateTime.Now.AddDays(30),
                });
            return new LoginDataDto
            {
                Token = jwtToken,
                RefreshToken = refreshToken
            };
         
        }
    }
}

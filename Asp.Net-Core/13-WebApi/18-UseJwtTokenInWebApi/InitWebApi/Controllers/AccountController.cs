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

        public AccountController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public IActionResult Post(string userName,string password)
        {
            if (true)
            {
                var claims = new List<Claim>
                {
                    new Claim("UserId",Guid.NewGuid().ToString()),
                    new Claim("Name","Mohammad Vahid Assari"),
                };

                string key = _configuration["JWTConfig:key"];
                var secretKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                var credentials=new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(issuer: _configuration["JWTConfig:issuer"], //چه کسی ایجاد کرده
                                                 audience: _configuration["JWTConfig:audience"], // چه کسی استفاده میکنه
                                                 expires:DateTime.Now.AddMinutes(int.Parse(_configuration["JWTConfig:expires"])), // چند وقت اعتبار داره
                                                 notBefore:DateTime.Now.AddMinutes(1),//از کی اعتبارش شروع بشه
                                                 claims:claims,
                                                 signingCredentials:credentials);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(jwtToken);
            }
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

                string key = "{56A65C30-C6B9-4457-821B-C20A578BEBEB}";
                var secretKey=new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
                var credentials=new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(issuer: "mva.com", //چه کسی ایجاد کرده
                                                 audience:"vahid.com", // چه کسی استفاده میکنه
                                                 expires:DateTime.Now.AddMinutes(2), // چند وقت اعتبار داره
                                                 notBefore:DateTime.Now.AddMinutes(1),//از کی اعتبارش شروع بشه
                                                 claims:claims,
                                                 signingCredentials:credentials);

                var jwtToken = new JwtSecurityTokenHandler().WriteToken(token);

                return Ok(jwtToken);
            }
        }
    }
}

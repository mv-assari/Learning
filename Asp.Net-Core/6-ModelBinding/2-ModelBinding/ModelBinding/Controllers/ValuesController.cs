using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //[HttpPost]
        //public IActionResult Edit(UserInfoDto user) //اطلاعات باید از طریق جیسون در بادی به بک ارسال بشه تا بتونه دریافت کنه واگرنه خطای 415 میده
        //{
        //    user.UserId = 20;
        //    return Ok();
        //}

        [HttpPost]
        public IActionResult Edit([FromQuery]UserInfoDto user) //اینجا بهش گفتیم دیگه از کجا دریافت کن
        {
            user.UserId = 20;
            return Ok();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingForWebApi.Controllers
{
    [Route("api/[controller]/[action]")]//به صورت اتومات خودش یه روت براش نوشته
    [ApiController] //اینجاهم از اتریبیوت مخصوص استفاده کرده
    public class HomeController : ControllerBase
    {
        [Route("~/products",Order =-1)]//اگر دوتا روت مشابه هم داشتیم میتوانیم ترتیب اجرا را مشخص کنیم پیش فرض عدد 0 هست اولویت بیشتر عدد کمتر
        [HttpGet]
        public string Pordcuts()
        {
            return "Home/prodcuts";
        }

        //برای هر اکشن هم میتونیم روت یا چند روت تعریف کنیم
        [Route("~/MyApi")]
        [Route("MyApi/Index")]
        [Route("MyApi/Index/{id?}")]
        [Route("[controller]/[action]/{id?}")]//از نام های رزرو شده استفاده میشه که خودش اتومات جایگزاری میکنه
        [Route("api/[controller]/[action]")]
        [HttpGet]
        public IActionResult Index(int id) 
        {
            return Ok(id);
        }

        [Route("~/Book/List")]
        [HttpGet]
        public IActionResult BookList()
        {
            return Ok(true);
        }
    }
}

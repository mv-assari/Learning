using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //اول روت رو میگرده
        //بعد کوئری استرینگ میگرده
        //بعد فرم رو میگرده
        //اگر دقیق مشخص کرده باشیم خودش میره بادی میگرده
        //اگر دقیق مشخص کرده باشیم خودش میره هدر رو میگرده
        //میتوان از خصوصیات مختلف استفاده کرد 
        //[FromRoute]
        //[FromQuery]
        //[FromForm]
        //[FromHeader]
        //[FromBody]
        //public IActionResult Index(int id,[FromQuery(Name ="personName")]string name) //برای تفاوت بین تغییر نام هنگام ارسال پارامتر از فرانت به بک
        public IActionResult Index() 
        {
            return View();
        }

        //public IActionResult Edit([Bind("FirstName","LastName")]UserInfoDto user) //مشخص میکنه فقط چه مقداری از سمت کاربر پذیرفته شود و دریافت شود
        [HttpPost]
        public IActionResult Edit([Bind("FirstName","LastName")]UserInfoDto user) 
        {
            //-------------

            return View();
        }
        


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OtherModelBinding.Models;

namespace OtherModelBinding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        //public IActionResult Edit(string[] ch)
        //public IActionResult Edit(IFormFile file)//فایلی که آپلود که میشه رو از این طریق دریافت میشه
        //public IActionResult Edit(IFormFileCollection files)//فایلهایی که آپلود که میشه رو از این طریق دریافت میشه
        //public IActionResult Edit(IFormCollection keyValues) //تمام مواردی که در فرم اتفاق می افتد را دریافت میکند
        //public IActionResult Edit(Dictionary<int,string> dic)//نوع دیکشنری نمیتونه قبول کنه و خطا میده و نمیدونم چرا

        //مدل بایندینگ سرویس هم میتواند برای ما اینجکت کنه
        //البته سرویس باید در آی او سی کانتینر تعریف شده باشه
        //این برای زمانی خوب هست که در یک کنترلر فقط در یک اکشن نیاز به این سرویس داریم پس با همین روش اینجکت میکنیم
        //public IActionResult Edit([FromServices] IMyService myService)


        public IActionResult Edit([FromServices] IMyService myService)
        {
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

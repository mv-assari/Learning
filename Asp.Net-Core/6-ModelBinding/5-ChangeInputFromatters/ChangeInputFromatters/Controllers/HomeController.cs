using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChangeInputFromatters.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ChangeInputFromatters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //تمام درخواست هایی که ما به سرور ارسال میکنیم به صورت پیشفرض با فرمت جیسون ارسال میشه
        //میتونیم این رو تغییر بدیم
        //میتونیم پکیج های مختلفی برای انجام این کار انجام بدیم
        //[Consumes("application/json")]
        //[Consumes("application/xml")]

        public IActionResult Index()
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

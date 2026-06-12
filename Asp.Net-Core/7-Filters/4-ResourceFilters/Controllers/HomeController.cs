using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AuthorizationFilter.Models;
using AuthorizationFilter.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AuthorizationFilter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[CacheResourceFilter] //چون در سازنده ورودی داریم پس از خصوصیت زیر استفاده میکنیم 
        //البته در جلسات بعدی تزریق وابستگی در خصوصیات رو آموزش میدیم
        [TypeFilter(typeof(CacheResourceFilter))]
        public IActionResult Index()
        {
            return View("Index",$"this is a text and generated at:{DateTime.Now.TimeOfDay}");
        }

        [AuthorizeActionFilter("User")]
        public IActionResult List()
        {
            return View();
        }

        [AuthorizeActionFilter("Admin")]
        public IActionResult Edit()
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

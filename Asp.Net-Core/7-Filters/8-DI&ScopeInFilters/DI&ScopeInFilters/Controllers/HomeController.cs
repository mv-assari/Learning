using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DI_ScopeInFilters.Models;
using DI_ScopeInFilters.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DI_ScopeInFilters.Controllers
{
    //[ShowMessage("Controller")]
    [TypeFilter(typeof(ShowMessage))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //[ShowMessage("Action")]
        [TypeFilter(typeof(ShowMessage))] //در این قسمت میتوان فیلترهایی که نیاز به تزریق وابستگی دارند را استفاده کرد ولی سرویس لایف تایم را نمیتوانیم مدیریت کنیم
        [ServiceFilter(typeof(ShowMessage))]// با این مورد میتوان سرویس لایف تایم را مدیریت میکنیم
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

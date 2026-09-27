using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LoggingInAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;

namespace LoggingInAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly Logger nlog = LogManager.GetCurrentClassLogger();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Sum(5, 6);
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

        private int Sum(int a,int b)
        {
            try
            {
                nlog.Trace("Enter Sum");
                nlog.Debug($"a={a} and b={b}");

                int c = a + b;
                nlog.Debug($"c=a+b ==> {c}");
                nlog.Info("sum method run");

                return c;
            }
            catch (Exception ex)
            {
                nlog.Error("error", ex);

                throw;
            }
        }
    }
}

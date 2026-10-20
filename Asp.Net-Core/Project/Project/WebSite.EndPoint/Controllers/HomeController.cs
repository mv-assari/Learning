using Application.HomePageService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebSite.EndPoint.Models;
using WebSite.EndPoint.Utilities.Filters;

namespace WebSite.EndPoint.Controllers
{
    [ServiceFilter(typeof(SaveVisitorFilter))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomePageService homePageService;

        public HomeController(ILogger<HomeController> logger, IHomePageService homePageService)
        {
            _logger = logger;
            this.homePageService = homePageService;
        }

        public IActionResult Index()
        {
            var data = homePageService.GetData();
            return View(data);
        }

        [Authorize]
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using Microsoft.Extensions.Logging;
using UrlGeneration.Models;

namespace UrlGeneration.Controllers
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
            //string url = Url.Action("Privacy");
            //string url = Url.Action("Privacy", "Home", new {id=5,name="mva"});
            //string url = Url.RouteUrl("route1");
            string url = Url.RouteUrl("route1", new {id=3,name="vahid"},protocol:Request.Scheme);
            return View();
            //return ControllerContext.MyDisplayRouteInfo("",$"URL :{url}");
        }

        //[HttpGet("MyHome/books/fa/destination")]
        //[HttpGet("MyHome/books/fa/destination/{id}/{name}")]
        //[HttpGet("MyHome/books/fa/destination/{id?}/{name?}",Name ="route1")]
        [HttpGet("MyHome/books/fa/destination/{id?}/{name?}",Name ="route1")]
        public IActionResult Privacy(int id,string name)
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ChachingRedisInASP.Models;
using ChachingRedisInASP.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace ChachingRedisInASP.Controllers
{
    //برای استفاده از ردیس در یک برنامه واقعی باید از پکیج زیر استفاده کنیم
    //Microsoft.Extensions.Caching.StackExchangeRedis
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;
        private readonly IDistributedCache _chache;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, IDistributedCache chache)
        {
            _logger = logger;
            _productRepository = productRepository;
            _chache = chache;
        }

        public IActionResult Index()
        {
            HomePageDto homePageData= new HomePageDto();

            var homePageChache= _chache.GetAsync("HomePageData").Result;
            if (homePageChache != null)
            {
                homePageData=JsonSerializer.Deserialize<HomePageDto>(homePageChache);
                ViewBag.From = "دیتا از کش دریافت شد";
            }
            else
            {
                homePageData = _productRepository.GetHomePageProducts();
                string jsonData=JsonSerializer.Serialize(homePageData);
                byte[] encodedJson=Encoding.UTF8.GetBytes(jsonData);

                var options = new DistributedCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(10));

                _chache.SetAsync("HomePageData", encodedJson,options);
                ViewBag.From = "دیتا از دیتابیس دریافت شد";
            }
            return View(homePageData);
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

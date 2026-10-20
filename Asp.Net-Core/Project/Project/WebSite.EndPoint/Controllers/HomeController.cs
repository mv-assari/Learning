using Application.HomePageService;
using Infrastructure.CacheHelpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        private readonly IDistributedCache cache;

        public HomeController(ILogger<HomeController> logger, IHomePageService homePageService, IDistributedCache cache)
        {
            _logger = logger;
            this.homePageService = homePageService;
            this.cache = cache;
        }

        public IActionResult Index()
        {
            HomePageDto homePageData = new HomePageDto();

            var homePageCache= cache.GetAsync(CacheHelper.GenerateHomePageCacheKey()).Result;

            if (homePageCache!=null)
            {
                homePageData = JsonSerializer.Deserialize<HomePageDto>(homePageCache);
            }
            else
            {
                homePageData = homePageService.GetData();
                string jsonData = JsonSerializer.Serialize(homePageData);
                byte[] encodedJson = Encoding.UTF8.GetBytes(jsonData);
                var options = new DistributedCacheEntryOptions()
                    .SetSlidingExpiration(CacheHelper.DefaultCacheDuration);

                cache.SetAsync(CacheHelper.GenerateHomePageCacheKey(), encodedJson, options);
            }

                
            return View(homePageData);
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

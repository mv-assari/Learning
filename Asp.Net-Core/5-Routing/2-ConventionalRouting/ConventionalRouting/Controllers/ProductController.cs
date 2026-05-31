using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace ConventionalRouting.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [HttpGet] //اگر نام دوتا از اکشن ها برابر بود میتوان با قرار دادن فعل ها آن ها را از هم متمایز کرد که روتینگ قاطی نکنه
        public IActionResult Edit()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        [HttpPost]
        public IActionResult Edit(string productName)
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace ConventionalRouting.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }

        public IActionResult Detail(string category, string url)
        {
            return ControllerContext.MyDisplayRouteInfo(category,url);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;

namespace RoutingForArea.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        [HttpGet("[area]/[controller]/[action]",Name ="AdminRoute")]
        public IActionResult Index()
        {
            return ControllerContext.MyDisplayRouteInfo();
        }
    }
}

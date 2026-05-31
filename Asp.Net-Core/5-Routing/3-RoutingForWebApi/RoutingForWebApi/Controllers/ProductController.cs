using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoutingForWebApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("~/products")]
        [HttpGet]
        public string Index()
        {
            return "Products/Index";
        }
    }
}

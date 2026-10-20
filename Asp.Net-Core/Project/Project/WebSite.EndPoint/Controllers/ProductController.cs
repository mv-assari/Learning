using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Dto.Response.Payment;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetCatalogItemPLPService getCatalogIItemPLPService;
        private readonly IGetCatalogItemPDPService getCatalogItemPDPService;

        public ProductController(IGetCatalogItemPLPService
            getCatalogIItemPLPService
            , IGetCatalogItemPDPService getCatalogItemPDPService
            )
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
        }
        public IActionResult Index(CatlogPLPRequestDto request)
        {
            var data = getCatalogIItemPLPService.Execute(request);
            return View(data);
        }

        public IActionResult Details(string slug)
        {
            var data = getCatalogItemPDPService.Execute(slug);
            return View(data);
        }
    }
}

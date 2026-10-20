using Application.Catalogs.CatalogItems.GetCatalogItemPDP;
using Application.Catalogs.CatalogItems.GetCatalogItemPLP;
using Application.Commetns.Commands;
using Application.Commetns.Queries;
using Dto.Response.Payment;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persistence.Migrations;

namespace WebSite.EndPoint.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetCatalogItemPLPService getCatalogIItemPLPService;
        private readonly IGetCatalogItemPDPService getCatalogItemPDPService;
        private readonly IMediator mediator;

        public ProductController(IGetCatalogItemPLPService
            getCatalogIItemPLPService
            , IGetCatalogItemPDPService getCatalogItemPDPService,
                IMediator mediator)
        {
            this.getCatalogIItemPLPService = getCatalogIItemPLPService;
            this.getCatalogItemPDPService = getCatalogItemPDPService;
            this.mediator = mediator;
        }
        public IActionResult Index(CatlogPLPRequestDto request)
        {
            var data = getCatalogIItemPLPService.Execute(request);
            return View(data);
        }

        public IActionResult Details(string slug)
        {
            var data = getCatalogItemPDPService.Execute(slug);
            GetCommentOfCatalogItemRequest itemDto = new GetCommentOfCatalogItemRequest()
            {
                CataLogItemId = data.Id,
            };
            var result = mediator.Send(itemDto).Result;

            return View(data);
        }

        public IActionResult SendComment(CommentDto commentDto, string Slug)
        {
            SendCommentCommand sendComment = new SendCommentCommand(commentDto);
            var result = mediator.Send(sendComment).Result;
            return RedirectToAction(nameof(Details), new { Slug = Slug });

        }
    }
}

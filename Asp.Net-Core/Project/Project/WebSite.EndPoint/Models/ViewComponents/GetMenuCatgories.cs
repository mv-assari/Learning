using Application.Catalogs.GetMenuItem;
using Microsoft.AspNetCore.Mvc;

namespace WebSite.EndPoint.Models.ViewComponents
{
    public class GetMenuCatgories:ViewComponent
    {
        private readonly IGetMenuItemService getMenuItemService;

        public GetMenuCatgories(IGetMenuItemService getMenuItemService)
        {
            this.getMenuItemService = getMenuItemService;
        }

        public IViewComponentResult Invoke()
        {
            var data = getMenuItemService.Execute();
            return View(viewName: "GetMenuCatgories",model: data);
        }
    }
}

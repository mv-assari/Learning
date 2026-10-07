using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.EndPoint.ViewModels.Catalogs;

//using Admin.EndPoint.ViewModels.Catalogs;
using Application.Catalogs.CatalogTypes;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.CatalogType
{
    public class DeleteModel : PageModel
    {
        private readonly ICatalogTypeService catalogTypeService;
        private readonly IMapper mapper;

        public DeleteModel(ICatalogTypeService catalogTypeService, IMapper mapper)
        {
            this.catalogTypeService = catalogTypeService;
            this.mapper = mapper;
        }

        [BindProperty]
        public CatalogTypeViewModel CatalogType {  get; set; }=new CatalogTypeViewModel();
        public List<string> Message { get; set; } = new List<string>();
        public void OnGet(int id)
        {
            var model = catalogTypeService.FindById(id);
            if(model.IsSuccess)
                CatalogType=mapper.Map<CatalogTypeViewModel>(model.Data);
            Message=model.Message;
        }

        public IActionResult OnPost()
        {
            var result = catalogTypeService.Remove(CatalogType.Id);
            Message=result.Message;
            if(result.IsSuccess)
                return RedirectToPage("Index");

            return Page();
        }
    }
}

using ConfigRazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace ConfigRazorPages.Pages.Admin.Product
{
    public class IndexModel : PageModel
    {
        public List<ProductDto> Products { get; set; } =new List<ProductDto>();

        private readonly IProductService _productService;

        public IndexModel(IProductService productService)
        {
            _productService = productService;
        }

        public void OnGet()
        {
            Products= _productService.List();
        }
    }
}

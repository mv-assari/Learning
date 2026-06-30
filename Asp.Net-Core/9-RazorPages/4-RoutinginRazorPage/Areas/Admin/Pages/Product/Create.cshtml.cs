using ConfigRazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConfigRazorPages.Pages.Admin.Product
{
    public class CreateModel : PageModel
    {
        private readonly IProductService _productService;

        public CreateModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductDto Product { get; set; }= new ProductDto();

        public void OnGet()
        {

        }

        public void OnPost()
        {
            _productService.Add(Product);
        }
    }
}

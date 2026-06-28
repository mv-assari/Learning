using ConfigRazorPages.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConfigRazorPages.Pages.Admin.Product
{
    public class DeleteModel : PageModel
    {
        private readonly IProductService _productService;

        public DeleteModel(IProductService productService)
        {
            _productService = productService;
        }

        [BindProperty]
        public ProductDto Product { get; set; }

        public IActionResult OnGet(int? id)
        {
            if (id == null)
                return NotFound();
            Product = _productService.Find(id.Value);

            return Page();
        }

        public IActionResult OnPost()
        {
            _productService.Delete(Product.Id);
            return RedirectToPage("Index");
        }
    }
}

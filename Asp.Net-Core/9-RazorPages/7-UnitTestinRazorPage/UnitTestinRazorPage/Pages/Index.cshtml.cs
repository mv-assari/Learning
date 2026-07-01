using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using UnitTestinRazorPage.Models;

namespace UnitTestinRazorPage.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ViewModelSum viewModelSum { get; set; } = new ViewModelSum();
        public IActionResult OnGet()
        {
            
            return Page();
        }

        public IActionResult OnPost() 
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Sum sum = new Sum();
            viewModelSum.Result=sum.Execute(viewModelSum.Value1, viewModelSum.Value2);
            return Page();
        }
    }
}

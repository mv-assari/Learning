using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConfigRazorPages.Models.Filters;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ConfigRazorPages.Pages
{
    [AddHeader("MyHeader","Mva")]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

       public void OnPost()
        {

        }


        //ادامه نام متد میشه هندلر اون که در سمت فرانت میشه ازاین طریق بین متدهای پست حالتهای مختلف داشت
        public void OnPostSendComment()
        {

        }

        public void OnPostSubscribe()
        {

        }

        [NonHandler]
        public void Function()
        {

        }

        
    }
}

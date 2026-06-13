using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using SelectListTagHelper.Models;

namespace SelectListTagHelper.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            var tehranGroup = new SelectListGroup { Name = "tehran teams" };
            var otherGroup = new SelectListGroup { Name = "other teams" };

            TeamViewModel teamViewModel = new TeamViewModel
            {
                Teams = new List<SelectListItem>
                {
                    new SelectListItem {Value="1",Text="perspolis" },
                    new SelectListItem {Value="2",Text="esteghlal" },
                    new SelectListItem {Value="3",Text="zobeahan" },
                    new SelectListItem {Value="4",Text="sepahan" },
                    new SelectListItem {Value="5",Text="teraktor" },
                },
                TeamsOptionGroup=new List<SelectListItem>
                {
                    new SelectListItem {Group=tehranGroup, Value="1",Text="perspolis" },
                    new SelectListItem {Group=tehranGroup,Value="2",Text="esteghlal" },
                    new SelectListItem {Group = otherGroup, Value="3",Text="zobeahan" },
                    new SelectListItem {Group = otherGroup,Value="4",Text="sepahan" },
                    new SelectListItem {Group = otherGroup,Value="5",Text="teraktor" },
                }

                
            };

            teamViewModel.Teams.Insert(0, new SelectListItem { Value = "", Text = "choose option" });
            //teamViewModel.Team = "3";

            return View(teamViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

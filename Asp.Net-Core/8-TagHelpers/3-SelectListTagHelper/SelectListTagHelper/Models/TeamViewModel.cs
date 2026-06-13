using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SelectListTagHelper.Models
{
    public class TeamViewModel
    {
        public string Team { get; set; }
        public List<SelectListItem> Teams { get; set; }
        public List<SelectListItem> TeamsOptionGroup { get; set; }

        public TeamEnum TeamEnum { get; set; }

    }

    public enum TeamEnum
    {
        [Display(Name = "پرسپولیس")]
        perspolis,
        esteghlal,
        sepahan,
        traktor
    }
}

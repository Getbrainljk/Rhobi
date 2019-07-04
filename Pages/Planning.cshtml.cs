using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace  RhobalasWeb.Pages
{
    public class PlanningModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Your contact page.";
        }
        public IActionResult OnGetPartial() =>
        new PartialViewResult
        {
            ViewName = "_ConstructionPartial",
            ViewData = ViewData,
        };
    }
}

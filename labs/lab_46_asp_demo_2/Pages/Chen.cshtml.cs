using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace lab_46_asp_demo_2.Pages
{
    public class ChenModel : PageModel
    {
        public static List<string> items = new List<string>() { "one", "two", "three" };
        public void OnGet()
        {
            items.Add("four");
        }
    }
}

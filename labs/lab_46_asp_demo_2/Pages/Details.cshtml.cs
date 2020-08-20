using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_46_asp_demo_2.Models;

namespace lab_46_asp_demo_2.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly lab_46_asp_demo_2.Models.NorthwindContext _context;

        public DetailsModel(lab_46_asp_demo_2.Models.NorthwindContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.CustomerId == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}

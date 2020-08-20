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
    public class IndexModel : PageModel
    {
        private readonly lab_46_asp_demo_2.Models.NorthwindContext _context;

        public IndexModel(lab_46_asp_demo_2.Models.NorthwindContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}

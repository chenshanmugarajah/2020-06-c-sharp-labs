using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using lab_47_personal_api_web.Models;

namespace lab_47_personal_api_web.Pages
{
    public class CreateModel : PageModel
    {
        private readonly lab_47_personal_api_web.Models.IndustryDbContext _context;

        public CreateModel(lab_47_personal_api_web.Models.IndustryDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public RecordLabel RecordLabel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RecordLabels.Add(RecordLabel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

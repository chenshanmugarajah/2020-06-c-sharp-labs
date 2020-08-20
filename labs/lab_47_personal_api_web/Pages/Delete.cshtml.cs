using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_47_personal_api_web.Models;

namespace lab_47_personal_api_web.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly lab_47_personal_api_web.Models.IndustryDbContext _context;

        public DeleteModel(lab_47_personal_api_web.Models.IndustryDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RecordLabel RecordLabel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RecordLabel = await _context.RecordLabels.FirstOrDefaultAsync(m => m.RecordLabelId == id);

            if (RecordLabel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            RecordLabel = await _context.RecordLabels.FindAsync(id);

            if (RecordLabel != null)
            {
                _context.RecordLabels.Remove(RecordLabel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

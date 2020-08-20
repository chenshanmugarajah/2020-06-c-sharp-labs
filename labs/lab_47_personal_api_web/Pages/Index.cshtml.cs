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
    public class IndexModel : PageModel
    {
        private readonly lab_47_personal_api_web.Models.IndustryDbContext _context;

        public IndexModel(lab_47_personal_api_web.Models.IndustryDbContext context)
        {
            _context = context;
        }

        public IList<RecordLabel> RecordLabel { get;set; }

        public async Task OnGetAsync()
        {
            RecordLabel = await _context.RecordLabels.ToListAsync();
        }
    }
}

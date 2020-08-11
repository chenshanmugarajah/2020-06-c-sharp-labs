using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_42_api_code_first_homework.Models;

namespace lab_42_api_code_first_homework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecordLabelsController : ControllerBase
    {
        private readonly IndustryDbContext _context;

        public RecordLabelsController(IndustryDbContext context)
        {
            _context = context;
        }

        // GET: api/RecordLabels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RecordLabel>>> GetRecordLabels()
        {
            return await _context.RecordLabels.Include("Songs").ToListAsync();
        }

        // GET: api/RecordLabels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RecordLabel>> GetRecordLabel(int id)
        {
            var recordLabel = await _context.RecordLabels.Include("Songs").SingleOrDefaultAsync(r => r.RecordLabelId == id);

            if (recordLabel == null)
            {
                return NotFound();
            }

            return recordLabel;
        }

        // PUT: api/RecordLabels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRecordLabel(int id, RecordLabel recordLabel)
        {
            if (id != recordLabel.RecordLabelId)
            {
                return BadRequest();
            }

            _context.Entry(recordLabel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RecordLabelExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RecordLabels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<RecordLabel>> PostRecordLabel(RecordLabel recordLabel)
        {
            _context.RecordLabels.Add(recordLabel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRecordLabel", new { id = recordLabel.RecordLabelId }, recordLabel);
        }

        // DELETE: api/RecordLabels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RecordLabel>> DeleteRecordLabel(int id)
        {
            var recordLabel = await _context.RecordLabels.FindAsync(id);
            if (recordLabel == null)
            {
                return NotFound();
            }

            _context.RecordLabels.Remove(recordLabel);
            await _context.SaveChangesAsync();

            return recordLabel;
        }

        private bool RecordLabelExists(int id)
        {
            return _context.RecordLabels.Any(e => e.RecordLabelId == id);
        }
    }
}

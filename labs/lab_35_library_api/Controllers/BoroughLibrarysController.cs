using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_35_library_api.Models;

namespace lab_32_library_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BoroughLibrarysController : ControllerBase
    {
        private readonly LibraryDBContext _context;

        public BoroughLibrarysController(LibraryDBContext context)
        {
            _context = context;
        }

        // GET: api/BoroughLibrarys
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BoroughLibrarys>>> GetBoroughLibrarys()
        {
            return await _context.BoroughLibrarys.ToListAsync();
        }

        // GET: api/BoroughLibrarys/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BoroughLibrarys>> GetBoroughLibrarys(int id)
        {
            var boroughLibrarys = await _context.BoroughLibrarys.FindAsync(id);

            if (boroughLibrarys == null)
            {
                return NotFound();
            }

            return boroughLibrarys;
        }

        // PUT: api/BoroughLibrarys/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBoroughLibrarys(int id, BoroughLibrarys boroughLibrarys)
        {
            if (id != boroughLibrarys.LibraryId)
            {
                return BadRequest();
            }

            _context.Entry(boroughLibrarys).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BoroughLibrarysExists(id))
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

        // POST: api/BoroughLibrarys
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<BoroughLibrarys>> PostBoroughLibrarys(BoroughLibrarys boroughLibrarys)
        {
            _context.BoroughLibrarys.Add(boroughLibrarys);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBoroughLibrarys", new { id = boroughLibrarys.LibraryId }, boroughLibrarys);
        }

        // DELETE: api/BoroughLibrarys/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<BoroughLibrarys>> DeleteBoroughLibrarys(int id)
        {
            var boroughLibrarys = await _context.BoroughLibrarys.FindAsync(id);
            if (boroughLibrarys == null)
            {
                return NotFound();
            }

            _context.BoroughLibrarys.Remove(boroughLibrarys);
            await _context.SaveChangesAsync();

            return boroughLibrarys;
        }

        private bool BoroughLibrarysExists(int id)
        {
            return _context.BoroughLibrarys.Any(e => e.LibraryId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using lab_26_cats_api.Models;

namespace lab_26_cats_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BreedsController : ControllerBase
    {
        private readonly CatDBContext _context;

        public BreedsController(CatDBContext context)
        {
            _context = context;
        }

        // GET: api/Breeds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Breeds>>> GetBreeds()
        {
            return await _context.Breeds.ToListAsync();
        }

        // GET: api/Breeds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Breeds>> GetBreeds(int id)
        {
            var breeds = await _context.Breeds.FindAsync(id);

            if (breeds == null)
            {
                return NotFound();
            }

            return breeds;
        }

        // PUT: api/Breeds/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBreeds(int id, Breeds breeds)
        {
            if (id != breeds.BreedId)
            {
                return BadRequest();
            }

            _context.Entry(breeds).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BreedsExists(id))
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

        // POST: api/Breeds
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Breeds>> PostBreeds(Breeds breeds)
        {
            _context.Breeds.Add(breeds);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBreeds", new { id = breeds.BreedId }, breeds);
        }

        // DELETE: api/Breeds/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Breeds>> DeleteBreeds(int id)
        {
            var breeds = await _context.Breeds.FindAsync(id);
            if (breeds == null)
            {
                return NotFound();
            }

            _context.Breeds.Remove(breeds);
            await _context.SaveChangesAsync();

            return breeds;
        }

        private bool BreedsExists(int id)
        {
            return _context.Breeds.Any(e => e.BreedId == id);
        }
    }
}

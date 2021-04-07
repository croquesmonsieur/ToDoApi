using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoApi.Models.Data;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClimberController : ControllerBase
    {
        private readonly ClimberContext _context;

        public ClimberController(ClimberContext context)
        {
            _context = context;
        }

        // GET: api/Climber
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Climbers>>> GetClimbers()
        {
            return await _context.Climbers.ToListAsync();
        }

        // GET: api/Climber/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Climbers>> GetClimbers(long id)
        {
            var climbers = await _context.Climbers.FindAsync(id);

            if (climbers == null)
            {
                return NotFound();
            }

            return climbers;
        }

        // PUT: api/Climber/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClimbers(long id, Climbers climbers)
        {
            if (id != climbers.Id)
            {
                return BadRequest();
            }

            _context.Entry(climbers).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClimbersExists(id))
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

        // POST: api/Climber
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Climbers>> PostClimbers(Climbers climbers)
        {
            _context.Climbers.Add(climbers);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClimbers", new { id = climbers.Id }, climbers);
        }

        // DELETE: api/Climber/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClimbers(long id)
        {
            var climbers = await _context.Climbers.FindAsync(id);
            if (climbers == null)
            {
                return NotFound();
            }

            _context.Climbers.Remove(climbers);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ClimbersExists(long id)
        {
            return _context.Climbers.Any(e => e.Id == id);
        }
    }
}

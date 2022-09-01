using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StartUpAcceloratorAPI.Models;

namespace StartUpAcceloratorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly StatisticsContext _context;

        public StatisticsController(StatisticsContext context)
        {
            _context = context;
        }

        // GET: api/Statistics
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Statistics>>> GetStatistics()
        {
          if (_context.Statistics == null)
          {
              return NotFound();
          }
            return await _context.Statistics.ToListAsync();
        }

        // GET: api/Statistics/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Statistics>> GetStatistics(int id)
        {
          if (_context.Statistics == null)
          {
              return NotFound();
          }
            var statistics = await _context.Statistics.FindAsync(id);

            if (statistics == null)
            {
                return NotFound();
            }

            return statistics;
        }

        // PUT: api/Statistics/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatistics(int id, Statistics statistics)
        {
            if (id != statistics.id)
            {
                return BadRequest();
            }

            _context.Entry(statistics).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatisticsExists(id))
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

        // POST: api/Statistics
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Statistics>> PostStatistics(Statistics statistics)
        {
          if (_context.Statistics == null)
          {
              return Problem("Entity set 'StatisticsContext.Statistics'  is null.");
          }
            _context.Statistics.Add(statistics);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStatistics", new { id = statistics.id }, statistics);
        }

        // DELETE: api/Statistics/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatistics(int id)
        {
            if (_context.Statistics == null)
            {
                return NotFound();
            }
            var statistics = await _context.Statistics.FindAsync(id);
            if (statistics == null)
            {
                return NotFound();
            }

            _context.Statistics.Remove(statistics);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatisticsExists(int id)
        {
            return (_context.Statistics?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}

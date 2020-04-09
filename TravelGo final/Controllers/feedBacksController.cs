using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelGo_final.Data;
using TravelGo_final.Model;

namespace TravelGo_final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class feedBacksController : ControllerBase
    {
        private readonly AppDbContext _context;

        public feedBacksController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/feedBacks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<feedBack>>> GetfeedBack()
        {
            return await _context.feedBack.ToListAsync();
        }

        // GET: api/feedBacks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<feedBack>> GetfeedBack(int id)
        {
            var feedBack = await _context.feedBack.FindAsync(id);

            if (feedBack == null)
            {
                return NotFound();
            }

            return feedBack;
        }

        // PUT: api/feedBacks/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutfeedBack(int id, feedBack feedBack)
        {
            if (id != feedBack.fid)
            {
                return BadRequest();
            }

            _context.Entry(feedBack).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!feedBackExists(id))
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

        // POST: api/feedBacks
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<feedBack>> PostfeedBack(feedBack feedBack)
        {
            _context.feedBack.Add(feedBack);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetfeedBack", new { id = feedBack.fid }, feedBack);
        }

        // DELETE: api/feedBacks/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<feedBack>> DeletefeedBack(int id)
        {
            var feedBack = await _context.feedBack.FindAsync(id);
            if (feedBack == null)
            {
                return NotFound();
            }

            _context.feedBack.Remove(feedBack);
            await _context.SaveChangesAsync();

            return feedBack;
        }

        private bool feedBackExists(int id)
        {
            return _context.feedBack.Any(e => e.fid == id);
        }
    }
}

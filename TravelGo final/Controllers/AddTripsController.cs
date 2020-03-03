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
    public class AddTripsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AddTripsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AddTrips
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddTrip>>> GetaddTrips()
        {
            return await _context.addTrips.ToListAsync();
        }

        // GET: api/AddTrips/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddTrip>> GetAddTrip(int id)
        {
            var addTrip = await _context.addTrips.FindAsync(id);

            if (addTrip == null)
            {
                return NotFound();
            }

            return addTrip;
        }

        // PUT: api/AddTrips/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddTrip(int id, AddTrip addTrip)
        {
            if (id != addTrip.tid)
            {
                return BadRequest();
            }

            _context.Entry(addTrip).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddTripExists(id))
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

        // POST: api/AddTrips
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AddTrip>> PostAddTrip(AddTrip addTrip)
        {
            _context.addTrips.Add(addTrip);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddTrip", new { id = addTrip.tid }, addTrip);
        }

        // DELETE: api/AddTrips/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AddTrip>> DeleteAddTrip(int id)
        {
            var addTrip = await _context.addTrips.FindAsync(id);
            if (addTrip == null)
            {
                return NotFound();
            }

            _context.addTrips.Remove(addTrip);
            await _context.SaveChangesAsync();

            return addTrip;
        }

        private bool AddTripExists(int id)
        {
            return _context.addTrips.Any(e => e.tid == id);
        }
    }
}

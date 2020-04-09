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
    public class AddUsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AddUsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/AddUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AddUser>>> GetaddUser()
        {
            return await _context.addUser.ToListAsync();
        }

        // GET: api/AddUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AddUser>> GetAddUser(int id)
        {
            var addUser = await _context.addUser.FindAsync(id);

            if (addUser == null)
            {
                return NotFound();
            }

            return addUser;
        }

        // PUT: api/AddUsers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAddUser(int id, AddUser addUser)
        {
            if (id != addUser.uid)
            {
                return BadRequest();
            }

            _context.Entry(addUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AddUserExists(id))
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

        // POST: api/AddUsers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<AddUser>> PostAddUser(AddUser addUser)
        {
            _context.addUser.Add(addUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAddUser", new { id = addUser.uid }, addUser);
        }

        // DELETE: api/AddUsers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AddUser>> DeleteAddUser(int id)
        {
            var addUser = await _context.addUser.FindAsync(id);
            if (addUser == null)
            {
                return NotFound();
            }

            _context.addUser.Remove(addUser);
            await _context.SaveChangesAsync();

            return addUser;
        }

        private bool AddUserExists(int id)
        {
            return _context.addUser.Any(e => e.uid == id);
        }
    }
}

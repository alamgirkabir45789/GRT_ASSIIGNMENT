using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GRT_ASSIIGNMENT.Data;
using GRT_ASSIIGNMENT.Models;
using Microsoft.AspNetCore.Authorization;

namespace GRT_ASSIIGNMENT.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationUserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ApplicationUserController(ApplicationDbContext context)
        {
            _context = context;
        }
     
        // GET: api/ApplicationUser
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetApplicationUsers()
        {
          if (_context.ApplicationUsers == null)
          {
              return NotFound();
          }
            return await _context.ApplicationUsers.ToListAsync();
        }

        // GET: api/ApplicationUser/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetApplicationUser(int id)
        {
          if (_context.ApplicationUsers == null)
          {
              return NotFound();
          }
            var applicationUser = await _context.ApplicationUsers.FindAsync(id);

            if (applicationUser == null)
            {
                return NotFound();
            }

            return applicationUser;
        }

        // PUT: api/ApplicationUser/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicationUser(int id, ApplicationUser applicationUser)
        {
            if (id != applicationUser.UserId)
            {
                return BadRequest();
            }

            _context.Entry(applicationUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicationUserExists(id))
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

        // POST: api/ApplicationUser
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ApplicationUser>> PostApplicationUser(ApplicationUser applicationUser)
        {
          if (_context.ApplicationUsers == null)
          {
              return Problem("Entity set 'ApplicationDbContext.ApplicationUsers'  is null.");
          }
            _context.ApplicationUsers.Add(applicationUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicationUser", new { id = applicationUser.UserId }, applicationUser);
        }

        // DELETE: api/ApplicationUser/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteApplicationUser(int id)
        {
            if (_context.ApplicationUsers == null)
            {
                return NotFound();
            }
            var applicationUser = await _context.ApplicationUsers.FindAsync(id);
            if (applicationUser == null)
            {
                return NotFound();
            }

            _context.ApplicationUsers.Remove(applicationUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ApplicationUserExists(int id)
        {
            return (_context.ApplicationUsers?.Any(e => e.UserId == id)).GetValueOrDefault();
        }
    }
}

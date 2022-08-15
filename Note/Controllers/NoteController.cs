using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Note.Data;
using Note.Model;

namespace Note.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly DataContext _context;
        public NoteController(DataContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Noted>>> Get(int userId)
        {
            var noted = await _context.Noteds
                .Where(c => c.userId == userId)
                .ToListAsync();
            return noted;
        }

        [HttpPost]
        public async Task<ActionResult<List<Noted>>> Create(Noted noted)
        {
            var user = await _context.Users.FindAsync(noted.userId);
            if(user == null)
                return NotFound();
            _context.Noteds.Add(noted);
            await _context.SaveChangesAsync();
            return await Get(noted.userId);
        }

    }
}

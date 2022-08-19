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
        public async Task<ActionResult<List<Magazine>>> Get(int userId)
        {
            var magazines = await _context.Magazines
                .Where(Magazine => Magazine.UserId == userId)
                .Include(Magazine => Magazine.Version)
                .ToListAsync();
            return magazines;
        }

        [HttpPost]
        public async Task<ActionResult<String>> Create(Magazine magazine)
        {
            var magazineobj = _context.Magazines.Add(magazine);
            await _context.SaveChangesAsync();
            return magazineobj.ToString();
        }
    }
}

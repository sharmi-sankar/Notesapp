using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Note.Data;
using System.Text.Json;
using Note.Model;

namespace Note.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create(User user)
        {
            var userobj = await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            string jsonString = JsonSerializer.Serialize(user);
            return Ok (jsonString);

        }
    }
}

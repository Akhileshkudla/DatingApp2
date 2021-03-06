using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<AppUser>> GetUsers() => await _context.Users.ToListAsync();      
       

        [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUsers(int id) => await _context.Users.FindAsync(id);
    }
}
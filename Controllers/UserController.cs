using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NosBlowa.Models;

namespace NosBlowa.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public UserController(ApiDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public object Get()
        {
            return _context.Users.Where(u => u.Username.Contains("Username")).Select((c) => new
            {
                Id = c.Id,
                Username = c.Username,
                Password = c.Password
            }).ToList();
        }
    }
}
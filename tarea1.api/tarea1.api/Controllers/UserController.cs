using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tarea1.api.Data;
using tarea1.api.Models;

namespace tarea1.api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController: ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context=context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users.ToListAsync();  
            return Ok(users);
        }


        [HttpGet("{identidad}")]
        public async Task<ActionResult<User>>GetUser(string identidad)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x=>x.userDNI==identidad);
            if (user==null)
            {
                return BadRequest("Usuario no existe");
            }
            return user;
        }

    }



}
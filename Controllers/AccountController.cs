using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

using CourseManagementSystemFinal.Models;
using CourseManagementSystemFinal.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagementSystemFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]



    // GET: api/Products

    public class AccountController : ControllerBase
    {
        private readonly MyDbContext _context;
        private readonly IAccountRepository repository;
        public AccountController(IAccountRepository repo, MyDbContext context)
        {
            repository = repo;
            _context = context;
        }



        [HttpPost("signup")]
        public async Task<IActionResult> SignUp(SignUpModel signupModel)
        {
            var result = await repository.SignUpAsync(signupModel);
            if (result.Succeeded)
            {
                return Ok(result);

            }
            return Unauthorized();
        }
        [HttpPost("Login")]
        public async Task<IActionResult> SignIn([FromBody] Login login)
        {
            var result = await repository.LoginAsync(login);
            if (string.IsNullOrEmpty(result))
            {
                return Unauthorized();
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ApplicationUser>> GetUserDetails(string id)
        {
            var user = await repository.GetUserByIdAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ApplicationUser>>> GetAllUsers()
        {
            var users = repository.GetAllUsers();
            if (users == null || !users.Any())
            {
                return NotFound("No users found");
            }
            return Ok(users);
        }
       
        
    }
}

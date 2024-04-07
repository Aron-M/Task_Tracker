using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Task_tracker_API.Models; // Replace with your actual User model namespace
using Task_tracker_API.Data; // Replace with your actual DbContext namespace
using Microsoft.AspNetCore.Identity; // If using ASP.NET Core Identity

namespace Task_Tracker_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager; // If using ASP.NET Core Identity

        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        // POST api/account/register
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Username = registerDto.Email,
                    Email = registerDto.Email,
                    // Other properties from the DTO
                };

                // If using ASP.NET Core Identity for user management
                var result = await _userManager.CreateAsync(user, registerDto.Password);

                if (result.Succeeded)
                {
                    // You might want to sign in the user or return a token here
                    return Ok(new { message = "User registered successfully." });
                }
                else
                {
                    return BadRequest(result.Errors);
                }
            }
            return BadRequest(ModelState);
        }

        // Other API endpoints related to account management...
    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Entities.Users;
using Project.Presentation.Areas.Admin.Models.DTOs.User;

namespace Project.Presentation.Areas.Admin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly UserManager<User> _userManager;

        public UsersController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] UserDto request)
        {
            
        }
    }
}

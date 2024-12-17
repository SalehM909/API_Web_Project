using Microsoft.AspNetCore.Mvc;
using API_Web_Project.DTO;
using API_Web_Project.Services;
using API_Web_Project.Services;

namespace API_Web_Project.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly UserService _userService;

        public UsersController(UserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public IActionResult Register([FromBody] RegisterDto model)
        {
            try
            {
                var user = _userService.Register(model);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Login")]
        public IActionResult Login([FromBody] LoginDto model)
        {
            try
            {
                var token = _userService.Login(model);
                return Ok(new { Token = token });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}

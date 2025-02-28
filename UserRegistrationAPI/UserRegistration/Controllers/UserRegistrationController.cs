using Microsoft.AspNetCore.Mvc;
using BusinessLayer;
using Models;

namespace UserRegistrationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        private readonly UserRegistrationBL _userRegistrationBL;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserRegistrationDTO userDto)
        {
            var result = _userRegistrationBL.RegisterUser(userDto);
            return Ok(result);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using BussinessLayer;

namespace UserRegistrationAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserRegistrationController : ControllerBase
    {
        UserRegistrationBL _userRegistrationBL;

        public UserRegistrationController(UserRegistrationBL userRegistrationBL)
        {
            _userRegistrationBL = userRegistrationBL;
        }

        [HttpGet("sweta")]
        public string Register(string username, string password)
        {
            return _userRegistrationBL.registrationBL(username, password);
        }
    }
}

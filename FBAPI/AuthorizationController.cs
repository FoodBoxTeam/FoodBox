using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FBAPI
{
    [Route("/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        [HttpGet("google-login")]
        public async Task<ActionResult> Google()
        {
            var properites = new AuthenticationProperties
            {
                RedirectUri = "/"
            };
            return Challenge(properites, GoogleDefaults.AuthenticationScheme); 
        }
    }
}

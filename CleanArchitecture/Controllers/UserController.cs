using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.Users.Commands;
using CleanArchitecture.Application.Users.Handlers;

namespace CleanArchitecture.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly RegisterUserHandler _handler;
        public UserController(RegisterUserHandler handler)
        {
            _handler = handler;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterUserCommand command)
        {
            try
            {
                await _handler.Handle(command);
                return Ok("User registered successfully.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // Add your actions here
    }
}
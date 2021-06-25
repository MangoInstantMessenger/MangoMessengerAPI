using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Models;
using MangoAPI.DTO.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginAsync(LoginCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(RegisterCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.AlreadyRegistered || !response.TermsAccepted)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
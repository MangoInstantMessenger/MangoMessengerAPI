using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase, IAuthController
    {
        private readonly IMediator _mediator;

        public AuthController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [SwaggerOperation(Summary = "Performs login to the messenger. Returns: Access token, Refresh Token ID. " +
            "Auth: allow anonymous")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand command,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [SwaggerOperation(Summary = "Registers user in a messenger. Requires input: e-mail, " +
            "phone, verification method (enum), password. " +
            "Auth: allow anonymous")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterCommand command,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("verify-email")]
        [SwaggerOperation(Summary = "Sends verification request with provided user parameters: " +
            "email, user ID guid. User receives proper link via email. " +
            "Auth: allow anonymous")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Task<IActionResult> VerifyEmailAsync(string email, string userId, CancellationToken cancellationToken)
        {
            var command = new VerifyEmailCommand { Email = email, UserId = userId };
            throw new System.NotImplementedException();
        }

        [AllowAnonymous]
        [HttpPost("verify-phone")]
        [SwaggerOperation(Summary = "Sends verification request with provided user parameters: phone confirmation code." +
            "Auth: allow anonymous")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> VerifyPhoneCodeAsync([FromBody] VerifyPhoneCommand command,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(command, cancellationToken);
            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        [SwaggerOperation(Summary = "Refreshes user's existing refresh token and access token. " +
            "Refresh token ID goes to cookies. Access token stays in application's memory. " +
            "Auth: refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> RefreshTokenAsync(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new RefreshTokenCommand(), cancellationToken);

            if (!result.Success)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }

        [Authorize]
        [HttpPost("logout")]
        [SwaggerOperation(Summary = "Logs out from current device. " +
            "Auth: refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> LogoutAsync(CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(new LogoutCommand(), cancellationToken));
        }

        [AllowAnonymous]
        [HttpPost("logout-all")]
        [SwaggerOperation(Summary = "Logs out from all devices. " +
            "Auth: refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public Task<IActionResult> LogoutAllDevicesAsync(CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        
    }
}
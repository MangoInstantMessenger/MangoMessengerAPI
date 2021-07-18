using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.Auth;
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
    public class AuthController : ApiContollerBase, IAuthController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [SwaggerOperation(Summary = "Performs login to the messenger. Returns: Access token, Refresh Token ID.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand command,
            CancellationToken cancellationToken) =>
            await CommandAsync(command, cancellationToken);

        [AllowAnonymous]
        [HttpPost("register")]
        [SwaggerOperation(Summary = "Registers user in a messenger.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterCommand command,
            CancellationToken cancellationToken) =>
            await CommandAsync(command, cancellationToken);

        [AllowAnonymous]
        [HttpGet("verify-email")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: E-mail, User's ID guid. " +
            "User receives confirmation link via email.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> VerifyEmailAsync(string email, string userId,
            CancellationToken cancellationToken) =>
            await CommandAsync(new VerifyEmailCommand(email, userId), cancellationToken);

        /// <summary>
        /// Sends verification request with provided user parameters: phone confirmation code.
        /// </summary>
        [AllowAnonymous]
        [HttpPost("verify-phone")]
        [ProducesResponseType(typeof(ResponseBase<VerifyPhoneResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> VerifyPhoneCodeAsync([FromBody] VerifyPhoneCommand command,
            CancellationToken cancellationToken) =>
            await CommandAsync(command, cancellationToken);

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        [SwaggerOperation(Summary = "Refreshes user's existing refresh token and access token.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RefreshTokenAsync(RefreshTokenCommand command,
            CancellationToken cancellationToken) =>
            await CommandAsync(command, cancellationToken);

        [Authorize]
        [HttpPost("logout")]
        [SwaggerOperation(Summary = "Logs out from current device.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAsync(LogoutCommand command, CancellationToken cancellationToken) =>
            await CommandAsync(command, cancellationToken);

        [Authorize]
        [HttpPost("logout-all")]
        [SwaggerOperation(Summary = "Logs out from all devices.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAllDevicesAsync(LogoutAllCommand command,
            CancellationToken cancellationToken) =>
            await CommandAsync(command, cancellationToken);
    }
}
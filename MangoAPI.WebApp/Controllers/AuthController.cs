using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.CommandModels.Auth;
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
    public class AuthController : ApiControllerBase, IAuthController
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [SwaggerOperation(Summary = "Performs login to the messenger. Returns: Access token, Refresh Token ID.")]
        [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommandModel commandModel,
            CancellationToken cancellationToken)
            => await RequestAsync(commandModel, cancellationToken);

        [AllowAnonymous]
        [HttpPost("register")]
        [SwaggerOperation(Summary = "Registers user in a messenger.")]
        [ProducesResponseType(typeof(RegisterResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(RegisterResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterCommandModel commandModel,
            CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);

        [AllowAnonymous]
        [HttpGet("verify-email")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: E-mail, User's ID guid. " +
            "User receives confirmation link via email.")]
        [ProducesResponseType(typeof(VerifyEmailResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(VerifyEmailResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> VerifyEmailAsync(string email, string userId,
            CancellationToken cancellationToken)
        {
            var command = new VerifyEmailCommandModel {Email = email, UserId = userId};
            return await RequestAsync(command, cancellationToken);
        }

        [AllowAnonymous]
        [HttpPost("verify-phone")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: phone confirmation code.")]
        [ProducesResponseType(typeof(VerifyPhoneResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(VerifyPhoneResponse), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> VerifyPhoneCodeAsync([FromBody] VerifyPhoneCommandModel commandModel,
            CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        [SwaggerOperation(Summary = "Refreshes user's existing refresh token and access token.")]
        [ProducesResponseType(typeof(RefreshTokenResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(RefreshTokenResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RefreshTokenAsync(RefreshTokenCommandModel commandModel,
            CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);

        [Authorize]
        [HttpPost("logout")]
        [SwaggerOperation(Summary = "Logs out from current device.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAsync(LogoutCommandModel commandModel, CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);

        [Authorize]
        [HttpPost("logout-all")]
        [SwaggerOperation(Summary = "Logs out from all devices.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAllDevicesAsync(LogoutAllCommandModel commandModel,
            CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);
    }
}
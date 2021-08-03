using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.Auth;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.Auth;
using MangoAPI.WebApp.Extensions;
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
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        [SwaggerOperation(Summary = "Registers user in a messenger.")]
        [ProducesResponseType(typeof(RegisterResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [AllowAnonymous]
        [HttpGet("verify-email")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: E-mail, User's ID guid. " +
            "User receives confirmation link via email.")]
        [ProducesResponseType(typeof(VerifyEmailResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> VerifyEmailAsync(string email, string userId,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(new VerifyEmailCommand {Email = email, UserId = userId}, cancellationToken);
        }

        [AllowAnonymous]
        [HttpPost("verify-phone")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: phone confirmation code.")]
        [ProducesResponseType(typeof(VerifyPhoneResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> VerifyPhoneCodeAsync([FromBody] VerifyPhoneRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        [SwaggerOperation(Summary = "Refreshes user's existing refresh token and access token.")]
        [ProducesResponseType(typeof(RefreshTokenResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [Authorize]
        [HttpPost("logout")]
        [SwaggerOperation(Summary = "Logs out from current device.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAsync([FromBody] LogoutRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [Authorize]
        [HttpPost("logout-all")]
        [SwaggerOperation(Summary = "Logs out from all devices.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAllDevicesAsync([FromBody] LogoutAllRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }
    }
}
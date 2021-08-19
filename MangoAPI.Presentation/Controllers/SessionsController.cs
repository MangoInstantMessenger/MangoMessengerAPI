namespace MangoAPI.Presentation.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.ApiCommands.Sessions;
    using MangoAPI.BusinessLogic.Responses;
    using MangoAPI.Presentation.Extensions;
    using MangoAPI.Presentation.Interfaces;
    using MediatR;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// Controller responsible for Sessions Entity.
    /// </summary>
    [ApiController]
    [Route("api/sessions")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SessionsController : ApiControllerBase, ISessionsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionsController"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        public SessionsController(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Logins to the system. Returns pair of the access/refresh tokens. Does not requires authorization.
        /// </summary>
        /// <param name="request">LoginRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost]
        [AllowAnonymous]
        [SwaggerOperation(Summary =
            "Logins to the system. Returns pair of the access/refresh tokens. Does not requires authorization.")]
        [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LoginAsync(
            [FromBody] LoginRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        /// <summary>
        /// Refreshes current user's session. Returns pair of the access/refresh tokens. Requires valid refresh token.
        /// </summary>
        /// <param name="refreshToken">Refresh Token ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [AllowAnonymous]
        [HttpPost("{refreshToken}")]
        [SwaggerOperation(Summary = "Refreshes current user's session. " +
                                    "Returns pair of the access/refresh tokens. " +
                                    "Requires valid refresh token.")]
        [ProducesResponseType(typeof(RefreshSessionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RefreshSession(
            [FromRoute] string refreshToken,
            CancellationToken cancellationToken)
        {
            var command = new RefreshSessionCommand
            {
                RefreshToken = refreshToken,
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Deletes current user's session. Requires roles: Unverified, User.
        /// </summary>
        /// <param name="refreshToken">Refresh Token ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete("{refreshToken}")]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Deletes current user's session. Requires roles: Unverified, User.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAsync(
            [FromRoute] string refreshToken,
            CancellationToken cancellationToken)
        {
            var command = new LogoutCommand { RefreshToken = refreshToken };
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Deletes all current user's sessions. Requires roles: Unverified, User.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Deletes all current user's sessions. Requires roles: Unverified, User.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAllAsync(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new LogoutAllCommand { UserId = userId };
            return await RequestAsync(command, cancellationToken);
        }
    }
}

using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/sessions")]
    public class SessionsController : ApiControllerBase, ISessionsController
    {
        public SessionsController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpPost]
        [SwaggerOperation(Summary = "Performs login to the messenger. Returns: Access token, Session Id.")]
        [ProducesResponseType(typeof(LoginResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [AllowAnonymous]
        [HttpPost("{refreshToken}")]
        [SwaggerOperation(Summary = "Refreshes current user's session. Returns: Access token, Session Id.")]
        [ProducesResponseType(typeof(RefreshSessionResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RefreshSession([FromRoute] string refreshToken,
            CancellationToken cancellationToken)
        {
            var command = new RefreshSessionCommand
            {
                RefreshToken = refreshToken
            };

            return await RequestAsync(command, cancellationToken);
        }

        [Authorize]
        [HttpDelete("{refreshToken}")]
        [SwaggerOperation(Summary = "Deletes session of current user's device.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAsync([FromRoute] string refreshToken,
            CancellationToken cancellationToken)
        {
            var command = new LogoutCommand {RefreshToken = refreshToken};
            return await RequestAsync(command, cancellationToken);
        }

        [Authorize]
        [HttpDelete]
        [SwaggerOperation(Summary = "Deletes all sessions of current user.")]
        [ProducesResponseType(typeof(LogoutResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> LogoutAllAsync(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new LogoutAllCommand {UserId = userId};
            return await RequestAsync(command, cancellationToken);
        }
    }
}
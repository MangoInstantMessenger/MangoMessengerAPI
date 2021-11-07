using AutoMapper;
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
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for Sessions Entity.
    /// </summary>
    [ApiController]
    [Route("api/sessions")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SessionsController : ApiControllerBase, ISessionsController
    {
        public SessionsController(IMediator mediator, IMapper mapper, RequestValidationService requestValidationService)
            : base(mediator, mapper, requestValidationService)
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
        [SwaggerOperation(Description =
                "Logins to the system. Returns pair of the access/refresh tokens. Does not requires authorization.",
            Summary = "Logins to the system.")]
        [ProducesResponseType(typeof(TokensResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginRequest request,
            CancellationToken cancellationToken)
        {
            var validateRequest = RequestValidationService
                .ValidateRequest(HttpContext, "Login", 30);

            if (!validateRequest)
            {
                return TooFrequentResponse();
            }

            var command = Mapper.Map<LoginCommand>(request);
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Refreshes current user's session. Returns pair of the access/refresh tokens. Requires valid refresh token.
        /// </summary>
        /// <param name="refreshToken">Refresh Token ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [AllowAnonymous]
        [HttpPost("{refreshToken:guid}")]
        [SwaggerOperation(Description = "Refreshes current user's session. " +
                                        "Returns pair of the access/refresh tokens. " +
                                        "Requires valid refresh token. Allow anonymous.",
            Summary = "Refreshes current user's session.")]
        [ProducesResponseType(typeof(TokensResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RefreshSession([FromRoute] Guid refreshToken,
            CancellationToken cancellationToken)
        {
            var validateRequest = RequestValidationService
                .ValidateRequest(HttpContext, "RefreshToken", 30);

            if (!validateRequest)
            {
                return TooFrequentResponse();
            }

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
        [HttpDelete("{refreshToken:guid}")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Description = "Deletes current user's session. Requires roles: User.",
            Summary = "Deletes current user's session.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LogoutAsync([FromRoute] Guid refreshToken,
            CancellationToken cancellationToken)
        {
            var validateRequest = RequestValidationService
                .ValidateRequest(HttpContext, "Logout", 30);

            if (!validateRequest)
            {
                return TooFrequentResponse();
            }
            
            var command = new LogoutCommand
            {
                RefreshToken = refreshToken
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Deletes all current user's sessions. Requires roles: Unverified, User.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Description = "Deletes all current user's sessions. Requires roles: User.",
            Summary = "Deletes all current user's sessions.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LogoutAllAsync(CancellationToken cancellationToken)
        {
            var validateRequest = RequestValidationService
                .ValidateRequest(HttpContext, "LogoutAll", 30);

            if (!validateRequest)
            {
                return TooFrequentResponse();
            }
            
            var userId = HttpContext.User.GetUserId();
            
            var command = new LogoutAllCommand
            {
                UserId = userId
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}
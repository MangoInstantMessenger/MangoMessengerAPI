using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.ApiQueries.Users;
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
    [Route("api/users")]
    public class UsersController : ApiControllerBase, IUsersController
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [AllowAnonymous]
        [HttpPost]
        [SwaggerOperation(Summary = "Registers user in a messenger.")]
        [ProducesResponseType(typeof(RegisterResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [AllowAnonymous]
        [HttpPut("email-confirmation")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: E-mail, User's ID guid. " +
            "User receives confirmation link via email.")]
        [ProducesResponseType(typeof(VerifyEmailResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> EmailConfirmationAsync(VerifyEmailRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            return await RequestAsync(command, cancellationToken);
        }

        [AllowAnonymous]
        [HttpPut("phone-confirmation")]
        [SwaggerOperation(Summary =
            "Sends verification request with provided user parameters: phone confirmation code.")]
        [ProducesResponseType(typeof(VerifyPhoneResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public Task<IActionResult> PhoneConfirmationAsync(VerifyPhoneRequest request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        [HttpGet("{userId}")]
        [SwaggerOperation(Summary = "Gets an information about particular user by user ID.")]
        [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetUserById([FromRoute] string userId, CancellationToken cancellationToken)
        {
            var query = new GetUserQuery {UserId = userId};
            return await RequestAsync(query, cancellationToken);
        }

        [Authorize]
        [HttpPost("searches")]
        [SwaggerOperation(Summary = "Searches user by display name.")]
        [ProducesResponseType(typeof(UserSearchResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchesAsync([FromBody] UserSearchCommand request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request, cancellationToken);
        }

        [Authorize]
        [HttpGet]
        [SwaggerOperation(Summary = "Gets an information about current user.")]
        [ProducesResponseType(typeof(GetUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var request = new GetUserQuery {UserId = userId};
            return await RequestAsync(request, cancellationToken);
        }

        [Authorize]
        [HttpPut("information")]
        [SwaggerOperation(Summary = "Updates user's personal information.")]
        [ProducesResponseType(typeof(UpdateUserInformationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateUserInformationAsync(UpdateUserInformationRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);

            return await RequestAsync(command, cancellationToken);
        }
    }
}
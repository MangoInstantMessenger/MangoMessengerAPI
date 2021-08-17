using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UsersController : ApiControllerBase, IUsersController
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        [AllowAnonymous]
        [SwaggerOperation(Summary =
            "Registers user in a messenger. Verification methods: 1 -- Phone, 2 -- Email. " +
            "Returns pair of tokens with Unverified user role.")]
        [ProducesResponseType(typeof(RegisterResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterRequest request,
            CancellationToken cancellationToken)
        {
            return await RequestAsync(request.ToCommand(), cancellationToken);
        }

        [HttpPut("email-confirmation")]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Confirms user's email.")]
        [ProducesResponseType(typeof(VerifyEmailResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> EmailConfirmationAsync([FromBody] VerifyEmailRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            return await RequestAsync(command, cancellationToken);
        }

        [HttpPut("{phoneCode:int}")]
        [Authorize(Roles = "Unverified, User")]
        [SwaggerOperation(Summary = "Confirms user's phone number.")]
        [ProducesResponseType(typeof(VerifyPhoneResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> PhoneConfirmationAsync([FromRoute] int phoneCode,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new VerifyPhoneCommand
            {
                UserId = userId,
                ConfirmationCode = phoneCode
            };
            
            return await RequestAsync(command, cancellationToken);
        }

        [HttpGet("{userId}")]
        [Authorize(Roles = "User")]
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

        [HttpPost("{displayName}")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Searches user by display name.")]
        [ProducesResponseType(typeof(UserSearchResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchesAsync(string displayName, CancellationToken cancellationToken)
        {
            var command = new UserSearchCommand
            {
                DisplayName = displayName
            };

            return await RequestAsync(command, cancellationToken);
        }

        [HttpGet]
        [Authorize(Roles = "Unverified, User")]
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

        [HttpPut("information")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Updates user's personal information.")]
        [ProducesResponseType(typeof(UpdateUserInformationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateUserInformationAsync([FromBody] UpdateUserInformationRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);

            return await RequestAsync(command, cancellationToken);
        }
    }
}
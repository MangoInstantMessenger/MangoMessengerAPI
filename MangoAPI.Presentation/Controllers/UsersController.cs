using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiQueries.Users;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.BusinessLogic.Responses.Users;
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

        [Authorize]
        [HttpGet("{userId}")]
        [SwaggerOperation(Summary = "Returns information about particular user by user ID.")]
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
        [HttpGet("search")]
        [SwaggerOperation(Summary = "Searches user by display name.")]
        [ProducesResponseType(typeof(UserSearchResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchUsersByDisplayName([FromQuery] string displayName,
            CancellationToken cancellationToken)
        {
            var query = new UserSearchQuery {DisplayName = displayName};
            return await RequestAsync(query, cancellationToken);
        }

        [Authorize]
        [HttpGet]
        [SwaggerOperation(Summary = "Returns information about current user logged in system.")]
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
    }
}
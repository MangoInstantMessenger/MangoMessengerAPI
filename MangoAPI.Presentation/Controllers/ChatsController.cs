namespace MangoAPI.Presentation.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessLogic.ApiCommands.Chats;
    using BusinessLogic.ApiQueries.Chats;
    using BusinessLogic.Responses;
    using Extensions;
    using Interfaces;
    using MediatR;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// Controller responsible for Chats Entity.
    /// </summary>
    [ApiController]
    [Route("api/chats")]
    [Produces("application/json")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ChatsController : ApiControllerBase, IChatsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatsController"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        public ChatsController(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Gets all current user's chats. Requires role: User.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet]
        [SwaggerOperation(Summary = "Gets all current user's chats. Requires role: User.")]
        [ProducesResponseType(typeof(GetCurrentUserChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChats(CancellationToken cancellationToken)
        {
            var request = new GetCurrentUserChatsQuery { UserId = HttpContext.User.GetUserId() };
            return await RequestAsync(request, cancellationToken);
        }

        /// <summary>
        /// Creates new group of specified type: Private Channel (2), Public Channel (3), Readonly Channel (4).
        /// Requires role: User.
        /// </summary>
        /// <param name="request">CreateGroupRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost]
        [SwaggerOperation(Summary =
            "Creates new group of specified type: Private Channel (2), Public Channel (3), Readonly Channel (4). " +
            "Requires role: User.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChatAsync(
            [FromBody] CreateGroupRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Creates new direct chat with specified user. User is fetched by parameter user ID.
        /// Requires role: User.
        /// </summary>
        /// <param name="userId">User ID of colleague, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("{userId}")]
        [SwaggerOperation(Summary = "Creates new direct chat with specified user. User is fetched by parameter user ID. " +
                                    "Requires role: User.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChatAsync(
            [FromRoute] string userId,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();
            var command = new CreateDirectChatCommand
            {
                PartnerId = userId,
                UserId = currentUserId,
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Searches chats by display name. Requires role: User.
        /// </summary>
        /// <param name="displayName">Display name of the chat, string.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("{displayName}")]
        [SwaggerOperation(Summary = "Searches chats by display name. Requires role: User.")]
        [ProducesResponseType(typeof(SearchChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchAsync(
            [FromRoute] string displayName,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new SearchChatsQuery
            {
                DisplayName = displayName,
                UserId = userId,
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}

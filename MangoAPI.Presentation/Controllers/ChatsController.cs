using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.ApiQueries.Chats;
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
            var userId = HttpContext.User.GetUserId();

            var request = new GetCurrentUserChatsQuery
            {
                UserId = userId
            };

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
            "Creates new group of specified type: Private Channel (3), Public Channel (4), Readonly Channel (5). " +
            "Requires role: User.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChatAsync([FromBody] CreateGroupRequest request,
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
        [HttpPost("{userId:guid}")]
        [SwaggerOperation(Summary =
            "Creates new direct chat with specified user. User is fetched by parameter user ID. " +
            "Requires role: User.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChatAsync([FromRoute] Guid userId,
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
        /// Gets chat by ID. Requires role: User.
        /// </summary>
        /// <param name="chatId">User ID of colleague, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("{chatId:guid}")]
        [SwaggerOperation(Summary = "Gets chat by ID. Requires role: User.")]
        [ProducesResponseType(typeof(GetChatByIdResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchById([FromRoute] Guid chatId,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();

            var query = new GetChatByIdQuery
            {
                UserId = currentUserId,
                ChatId = chatId,
            };

            return await RequestAsync(query, cancellationToken);
        }


        /// <summary>
        /// Searches chats by display name. Requires role: User.
        /// </summary>
        /// <param name="displayName">Display name of the chat, string.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("searches")]
        [SwaggerOperation(Summary = "Searches chats by display name. Requires role: User.")]
        [ProducesResponseType(typeof(SearchChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchAsync([FromQuery] string displayName,
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
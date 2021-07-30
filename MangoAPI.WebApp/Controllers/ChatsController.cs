using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.Chats;
using MangoAPI.DTO.ApiQueries.Chats;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.Chats;
using MangoAPI.WebApp.Extensions;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/chats")]
    [Produces("application/json")]
    public class ChatsController : ApiControllerBase, IChatsController
    {
        public ChatsController(IMediator mediator) : base(mediator)
        {
        }

        [Authorize]
        [HttpGet]
        [SwaggerOperation(Summary = "Returns list of all user's chats.")]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChats(CancellationToken cancellationToken)
        {
            var request = new GetCurrentUserChatsQuery {UserId = HttpContext.User.GetUserId()};
            return await RequestAsync(request, cancellationToken);
        }

        [Authorize]
        [HttpPost("group")]
        [SwaggerOperation(Summary =
            "Creates new group of specified type. 2 -- Private Channel, 3 -- Public Channel, 4 -- ReadOnlyChannel")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChat([FromBody] CreateGroupRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }

        [Authorize]
        [HttpPost("direct-chat")]
        [SwaggerOperation(Summary = "Creates new direct chat with specified user.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateDirectChat([FromBody] CreateDirectChatRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }

        [Authorize]
        [HttpPost("join")]
        [SwaggerOperation(Summary = "Joins to the particular public group.")]
        [ProducesResponseType(typeof(JoinChatResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> JoinChat([FromBody] JoinChatRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }

        [Authorize]
        [HttpGet("search")]
        [SwaggerOperation(Summary = "Searches chats by display name.")]
        [ProducesResponseType(typeof(SearchChatsQuery), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchChat([FromQuery] string displayName, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var request = new SearchChatsQuery {DisplayName = displayName, UserId = userId};
            return await RequestAsync(request, cancellationToken);
        }
    }
}
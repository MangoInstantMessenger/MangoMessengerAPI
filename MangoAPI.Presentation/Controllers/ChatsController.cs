using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.ApiQueries.Chats;
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
        [ProducesResponseType(typeof(GetCurrentUserChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChats(CancellationToken cancellationToken)
        {
            var request = new GetCurrentUserChatsQuery {UserId = HttpContext.User.GetUserId()};
            return await RequestAsync(request, cancellationToken);
        }

        [Authorize]
        [HttpPost]
        [SwaggerOperation(Summary =
            "Creates new group of specified type. 2 -- Private Channel, 3 -- Public Channel, 4 -- ReadOnlyChannel")]
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

        [Authorize]
        [HttpPost("{id}")]
        [SwaggerOperation(Summary = "Creates new direct chat by user ID.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChatAsync([FromRoute] string id, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new CreateDirectChatCommand
            {
                PartnerId = id,
                UserId = userId
            };

            return await RequestAsync(command, cancellationToken);
        }

        [Authorize]
        [HttpPost("searches")]
        [SwaggerOperation(Summary = "Searches chats by display name.")]
        [ProducesResponseType(typeof(SearchChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchAsync(SearchChatsRequest request, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.CommandModels.Chats;
using MangoAPI.DTO.QueryModels.Chats;
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
        [ProducesResponseType(typeof(GetChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChats(CancellationToken cancellationToken)
        {
            var request = new GetChatsQueryModel {UserId = HttpContext.User.GetUserId()};
            return await RequestAsync(request, cancellationToken);
        }

        [Authorize]
        [HttpPost("group")]
        [SwaggerOperation(Summary = "Creates new group of specified type.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateChat(CreateGroupCommandModel commandModel, CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);

        [Authorize]
        [HttpPost("direct-chat")]
        [SwaggerOperation(Summary = "Creates new direct chat with specified user.")]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(CreateChatEntityResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> CreateDirectChat(CreateDirectChatCommandModel commandModel,
            CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);

        [Authorize]
        [HttpPost("group/join")]
        [SwaggerOperation(Summary = "Joins to the particular public group.")]
        [ProducesResponseType(typeof(JoinChatResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(JoinChatResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> JoinChat(JoinChatCommandModel commandModel, CancellationToken cancellationToken) =>
            await RequestAsync(commandModel, cancellationToken);
    }
}
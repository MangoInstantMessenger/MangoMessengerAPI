using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiQueries.Messages;
using MangoAPI.DTO.RequestModels.Messages;
using MangoAPI.DTO.Responses.Messages;
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
    [Authorize]
    [Route("api/messages")]
    public class MessagesController : ApiControllerBase, IMessagesController
    {
        public MessagesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet("{chatId}")]
        [SwaggerOperation(Summary = "Returns chat including messages by chat ID.")]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChatMessages([FromRoute] string chatId, CancellationToken cancellationToken)
        {
            var query = new GetMessagesQuery {ChatId = chatId, UserId = HttpContext.User.GetUserId()};
            return await RequestAsync(query, cancellationToken);
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Sends message to particular chat.")]
        [ProducesResponseType(typeof(SendMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(SendMessageResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SendMessage(SendMessageRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            command.UserId = HttpContext.User.GetUserId();
            return await RequestAsync(command, cancellationToken);
        }

        [HttpPut]
        [SwaggerOperation(Summary = "Updates particular message.")]
        [ProducesResponseType(typeof(EditMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(EditMessageResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> EditMessage(EditMessageRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            command.UserId = HttpContext.User.GetUserId();
            return await RequestAsync(command, cancellationToken);
        }

        [HttpDelete]
        [SwaggerOperation(Summary = "Deletes particular message by ID.")]
        [ProducesResponseType(typeof(DeleteMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DeleteMessageResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> DeleteMessage(DeleteMessageRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();
            command.UserId = HttpContext.User.GetUserId();
            return await RequestAsync(command, cancellationToken);
        }
    }
}
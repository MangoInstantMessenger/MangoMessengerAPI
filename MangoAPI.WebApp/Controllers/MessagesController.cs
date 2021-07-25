using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Queries.Messages;
using MangoAPI.DTO.Responses.Messages;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessagesController : ApiControllerBase, IMessagesController
    {
        public MessagesController(IMediator mediator) : base(mediator)
        {
        }

        [Authorize]
        [HttpGet("{chatId:int}")]
        [SwaggerOperation(Summary = "Returns chat including messages by chat ID.")]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChatMessages([FromRoute] int chatId, CancellationToken cancellationToken)
        {
            var query = new GetMessagesQuery {ChatId = chatId};
            return await RequestAsync(query, cancellationToken);
        }

        [Authorize]
        [HttpPost]
        [SwaggerOperation(Summary = "Sends message to particular chat.")]
        [ProducesResponseType(typeof(SendMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(SendMessageResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SendMessage(SendMessageCommand command, CancellationToken cancellationToken) =>
            await RequestAsync(command, cancellationToken);
        
        [Authorize]
        [HttpPut]
        [SwaggerOperation(Summary = "Updates particular message.")]
        [ProducesResponseType(typeof(EditMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(EditMessageResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> EditMessage(EditMessageCommand command, CancellationToken cancellationToken) =>
            await RequestAsync(command, cancellationToken);

        [Authorize]
        [HttpDelete("{messageId:int}")]
        [SwaggerOperation(Summary = "Deletes particular message by ID.")]
        [ProducesResponseType(typeof(DeleteMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(DeleteMessageResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> DeleteMessage([FromRoute] int messageId, CancellationToken cancellationToken)
        {
            var command = new DeleteMessageCommand {MessageId = messageId};
            return await RequestAsync(command, cancellationToken);
        }
    }
}
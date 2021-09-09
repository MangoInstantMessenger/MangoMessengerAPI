using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using MangoAPI.BusinessLogic.ApiQueries.Messages;
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
    /// Controller responsible for Messages Entity.
    /// </summary>
    [ApiController]
    [Route("api/messages")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class MessagesController : ApiControllerBase, IMessagesController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesController"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        public MessagesController(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Returns all chat messages by chat ID. Requires role: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("{chatId:guid}")]
        [SwaggerOperation(Summary = "Returns all chat messages by chat ID. Requires role: User.")]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetChatMessages([FromRoute] Guid chatId,
            CancellationToken cancellationToken)
        {
            var query = new GetMessagesQuery {ChatId = chatId, UserId = HttpContext.User.GetUserId()};
            return await RequestAsync(query, cancellationToken);
        }

        /// <summary>
        /// Searches messages by content in particular chat. Requires role: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="messageText">Searched text.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("searches/{chatId:guid}")]
        [SwaggerOperation(Summary = "Searches messages by content in particular chat. Requires role: User.")]
        [ProducesResponseType(typeof(SearchChatMessagesResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SearchChatMessages([FromRoute] Guid chatId, [FromQuery] string messageText,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();

            var query = new SearchChatMessagesQuery
            {
                ChatId = chatId,
                MessageText = messageText,
                UserId = currentUserId
            };

            return await RequestAsync(query, cancellationToken);
        }

        /// <summary>
        /// Sends message to the particular chat. Requires role: User.
        /// </summary>
        /// <param name="request">SendMessageRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost]
        [SwaggerOperation(Summary = "Sends message to the particular chat. Requires role: User.")]
        [ProducesResponseType(typeof(SendMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Updates particular message. Requires role: User.
        /// </summary>
        /// <param name="request">EditMessageRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut]
        [SwaggerOperation(Summary = "Updates particular message. Requires role: User.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> EditMessage([FromBody] EditMessageRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Deletes particular message by message ID. Requires role: User.
        /// </summary>
        /// <param name="messageId">Message ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete("{messageId:guid}")]
        [SwaggerOperation(Summary = "Deletes particular message by message ID. Requires role: User.")]
        [ProducesResponseType(typeof(DeleteMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> DeleteMessage([FromRoute] Guid messageId,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var command = new DeleteMessageCommand
            {
                MessageId = messageId,
                UserId = userId,
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}
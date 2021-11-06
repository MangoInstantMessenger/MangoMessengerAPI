using AutoMapper;
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
using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;

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
        public MessagesController(IMediator mediator, IMapper mapper, RequestValidationService requestValidationService)
            : base(mediator, mapper, requestValidationService)
        {
        }

        /// <summary>
        /// Returns all chat messages by chat ID. Requires role: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("{chatId:guid}")]
        [SwaggerOperation(Description = "Returns all chat messages by chat ID. Requires role: User.",
            Summary = "Returns chat messages by ID.")]
        [ProducesResponseType(typeof(GetMessagesResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> GetChatMessages([FromRoute] Guid chatId,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var query = new GetMessagesQuery
            {
                ChatId = chatId,
                UserId = userId
            };

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
        [SwaggerOperation(Description = "Searches messages by content in particular chat. Requires role: User.",
            Summary = "Searches messages in chat.")]
        [ProducesResponseType(typeof(SearchChatMessagesResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
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
        [SwaggerOperation(Description = "Sends message to the particular chat. Requires role: User.",
            Summary = "Sends message to the chat.")]
        [ProducesResponseType(typeof(SendMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> SendMessage([FromBody] SendMessageRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = Mapper.Map<SendMessageCommand>(request);
            command.UserId = userId;
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Updates particular message. Requires role: User.
        /// </summary>
        /// <param name="request">EditMessageRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut]
        [SwaggerOperation(Description = "Updates particular message. Requires role: User.",
            Summary = "Updates particular message.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> EditMessage([FromBody] EditMessageRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = Mapper.Map<EditMessageCommand>(request);
            command.UserId = userId;
            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Deletes particular message by message ID. Requires role: User.
        /// </summary>
        /// <param name="messageId">Message ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete("{messageId:guid}")]
        [SwaggerOperation(Description = "Deletes particular message by message ID. Requires role: User.",
            Summary = "Updates particular message.")]
        [ProducesResponseType(typeof(DeleteMessageResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
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
using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
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
    /// Controller responsible for UserChats Entities.
    /// </summary>
    [ApiController]
    [Route("api/user-chats")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserChatsController : ApiControllerBase, IUserChatsController
    {
        public UserChatsController(IMediator mediator, IMapper mapper,
            RequestValidationService requestValidationService) : base(mediator, mapper, requestValidationService)
        {
        }

        /// <summary>
        /// Archives or un-archives chat. Requires roles: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut("{chatId:guid}")]
        [SwaggerOperation(Description = "Archives or un-archives chat. Requires roles: User.",
            Summary = "Archives or un-archives chat.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> ArchiveChat([FromRoute] Guid chatId,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new ArchiveChatCommand
            {
                UserId = userId,
                ChatId = chatId
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Joins to the particular public group. Fetches group by ID. Requires roles: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("{chatId:guid}")]
        [SwaggerOperation(Description =
                "Joins to the particular public group. Fetches group by ID. Requires roles: User.",
            Summary = "Joins to the particular public group.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> JoinChatAsync([FromRoute] Guid chatId, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var command = new JoinChatCommand
            {
                UserId = userId,
                ChatId = chatId,
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Leaves from the particular public group. Fetches group by ID. Requires roles: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete("{chatId:guid}")]
        [SwaggerOperation(Description =
                "Leaves from the particular public group. Fetches group by ID. Requires roles: User.",
            Summary = "Leaves from the particular public group.")]
        [ProducesResponseType(typeof(LeaveGroupResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> LeaveGroup([FromRoute] Guid chatId, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var command = new LeaveGroupCommand
            {
                UserId = userId,
                ChatId = chatId,
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}
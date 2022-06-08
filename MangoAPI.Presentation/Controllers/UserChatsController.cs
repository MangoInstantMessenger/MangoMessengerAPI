using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for UserChats Entities.
/// </summary>
[ApiController]
[Route("api/user-chats/{chatId:guid}")]
[Authorize]
public class UserChatsController : ApiControllerBase, IUserChatsController
{
    public UserChatsController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext) : base(
        mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Archives or un-archives chat.
    /// </summary>
    /// <param name="chatId">Chat ID, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPut]
    [SwaggerOperation(
        Description = "Archives or un-archives chat.",
        Summary = "Archives or un-archives chat.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> ArchiveChat([FromRoute] Guid chatId,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var command = new ArchiveChatCommand(userId, chatId);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Joins to the particular public group by group ID.
    /// </summary>
    /// <param name="chatId">Chat ID, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPost]
    [SwaggerOperation(
        Description = "Joins to the particular public group. Fetches group by ID.",
        Summary = "Joins to the particular public group.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> JoinChatAsync([FromRoute] Guid chatId, CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new JoinChatCommand(userId, chatId);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Leaves from the particular public group. Fetches group by ID.
    /// </summary>
    /// <param name="chatId">Chat ID, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpDelete]
    [SwaggerOperation(
        Description = "Leaves from the particular public group. Fetches group by ID.",
        Summary = "Leaves from the particular public group.")]
    [ProducesResponseType(typeof(LeaveGroupResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> LeaveGroup([FromRoute] Guid chatId, CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new LeaveGroupCommand(userId, chatId);

        return await RequestAsync(command, cancellationToken);
    }
}
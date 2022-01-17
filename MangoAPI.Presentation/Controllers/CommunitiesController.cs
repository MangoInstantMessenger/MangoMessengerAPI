using System;
using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for CommunityType Entity.
/// </summary>
[ApiController]
[Route("api/communities")]
[Produces("application/json")]
[Authorize]
public class CommunitiesController : ApiControllerBase, ICommunitiesController
{
    public CommunitiesController(IMediator mediator, IMapper mapper)
        : base(mediator, mapper)
    {
    }

    /// <summary>
    /// Gets all current user's chats.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpGet]
    [SwaggerOperation(
        Description = "Gets all current user's chats.",
        Summary = "Gets all user's chats.")]
    [ProducesResponseType(typeof(GetCurrentUserChatsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetChatsAsync(CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var request = new GetCurrentUserChatsQuery
        {
            UserId = userId
        };

        return await RequestAsync(request, cancellationToken);
    }

    /// <summary>
    /// Creates new group of specified type: Private Channel (3), Public Channel (4), Readonly Channel (5).
    /// </summary>
    /// <param name="request">CreateChannelRequest instance.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPost("channel")]
    [SwaggerOperation(
        Description =
            "Creates new group of specified type: Private Channel (3), Public Channel (4), Readonly Channel (5).",
        Summary = "Creates new group of specified type.")]
    [ProducesResponseType(typeof(CreateCommunityResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateChannelAsync([FromBody] CreateChannelRequest request,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();
        var command = Mapper.Map<CreateChannelCommand>(request);
        command.UserId = userId;
        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Creates new direct chat with specified user. User is fetched by parameter user ID.
    /// </summary>
    /// <param name="request">CreateChatRequest instance.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPost("chat")]
    [SwaggerOperation(
        Description = "Creates new chat with specified user. Chat types: Direct Chat (1), Secret Chat (2).",
        Summary = "Creates new chat with specified user.")]
    [ProducesResponseType(typeof(CreateCommunityResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CreateChatAsync([FromBody] CreateChatRequest request,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = Mapper.Map<CreateChatCommand>(request);
        command.UserId = userId;

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Searches chats by display name.
    /// </summary>
    /// <param name="displayName">Display name of the chat, string.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpGet("searches")]
    [SwaggerOperation(
        Description = "Searches chats by display name.",
        Summary = "Searches chats by display name.")]
    [ProducesResponseType(typeof(SearchCommunityResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SearchAsync([FromQuery] string displayName,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new SearchCommunityQuery
        {
            DisplayName = displayName,
            UserId = userId,
        };

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Updates picture of particular channel.
    /// </summary>
    /// <param name="chatId">Identifier of chat to be updated.</param>
    /// <param name="newGroupPicture">Picture file.</param>
    /// <param name="cancellationToken">Instance of cancellation token.</param>
    /// <returns></returns>
    [HttpPost("picture/{chatId:guid}")]
    [SwaggerOperation(
        Description = "Updates picture of particular channel.",
        Summary = "Updates picture of particular channel.")]
    [ProducesResponseType(typeof(UpdateChannelPictureResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> UpdateChannelPictureAsync([FromRoute] Guid chatId, IFormFile newGroupPicture,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new UpdateChanelPictureCommand
        {
            ChatId = chatId,
            UserId = userId,
            NewGroupPicture = newGroupPicture
        };

        return await RequestAsync(command, cancellationToken);
    }
}
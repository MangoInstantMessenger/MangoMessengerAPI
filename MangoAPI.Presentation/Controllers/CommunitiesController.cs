﻿using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using MangoAPI.BusinessLogic.ApiQueries.Communities;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for CommunityType Entity.
    /// </summary>
    [ApiController]
    [Route("api/communities")]
    [Produces("application/json")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class CommunitiesController : ApiControllerBase, ICommunitiesController
    {
        public CommunitiesController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }

        /// <summary>
        /// Gets all current user's chats. Requires role: User.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet]
        [SwaggerOperation(Description = "Gets all current user's chats. Requires role: User.",
            Summary = "Gets all user's chats.")]
        [ProducesResponseType(typeof(GetCurrentUserChatsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> GetChats(CancellationToken cancellationToken)
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
        /// Requires role: User.
        /// </summary>
        /// <param name="request">CreateChannelRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("channel")]
        [SwaggerOperation(Description =
            "Creates new group of specified type: Private Channel (3), Public Channel (4), Readonly Channel (5). " +
            "Requires role: User.",
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
        /// Requires role: User.
        /// </summary>
        /// <param name="request">CreateChatRequest instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("chat")]
        [SwaggerOperation(Description =
            "Creates new chat with specified user. Chat types: Direct Chat (1), Secret Chat (2). " +
            "Requires role: User.",
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
        /// Searches chats by display name. Requires role: User.
        /// </summary>
        /// <param name="displayName">Display name of the chat, string.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("searches")]
        [SwaggerOperation(Description = "Searches chats by display name. Requires role: User.",
            Summary = "Searches chats by display name.")]
        [ProducesResponseType(typeof(SearchCommunityResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
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
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        [HttpPut("picture")]
        [SwaggerOperation(Description = "Updates picture of particular channel. Required role: User",
            Summary = "Updates picture of particular channel.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> UpdateChannelPicture(UpdateChanelPictureRequest request, CancellationToken cancellationToken)
        {
            var command = Mapper.Map<UpdateChanelPictureCommand>(request);
            command.UserId = HttpContext.User.GetUserId();

            return await RequestAsync(command, cancellationToken);
        }
    }
}
namespace MangoAPI.Presentation.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessLogic.ApiCommands.UserChats;
    using BusinessLogic.Responses;
    using Extensions;
    using Interfaces;
    using MediatR;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// Controller responsible for UserChats Entities.
    /// </summary>
    [ApiController]
    [Route("api/user-chats")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserChatsController : ApiControllerBase, IUserChatsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserChatsController"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        public UserChatsController(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Joins to the particular public group. Fetches group by ID. Requires roles: User.
        /// </summary>
        /// <param name="chatId">Chat ID, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("{chatId}")]
        [SwaggerOperation(Summary =
            "Joins to the particular public group. Fetches group by ID. Requires roles: User.")]
        [ProducesResponseType(typeof(JoinChatResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> JoinChatAsync([FromRoute] string chatId, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new JoinChatCommand
            {
                UserId = userId,
                ChatId = chatId,
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}

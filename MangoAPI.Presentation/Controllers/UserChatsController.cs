using System.Threading;
using System.Threading.Tasks;
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
    [ApiController]
    [Route("api/user-chats")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class UserChatsController : ApiControllerBase, IUserChatsController
    {
        public UserChatsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("{chatId}")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Summary = "Joins to the particular public group.")]
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
                ChatId = chatId
            };
            
            return await RequestAsync(command, cancellationToken);
        }
    }
}
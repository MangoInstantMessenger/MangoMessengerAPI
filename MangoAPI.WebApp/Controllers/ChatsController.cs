using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Queries.Chats;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/chats")]
    public class ChatsController : ControllerBase, IChatsController
    {
        [Authorize]
        [HttpGet]
        [SwaggerOperation(Summary = "Returns list of all user's chats")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> GetChats(GetChatsQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        
        [Authorize]
        [HttpPost]
        [SwaggerOperation(Summary = "Sends message to particular chats")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> CreateChat(CreateChatCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
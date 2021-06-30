using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Queries.Messages;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessagesController : ControllerBase, IMessagesController
    {
        [Authorize]
        [HttpGet]
        [SwaggerOperation(Description = "Returns list of all messages of specified chat by chat ID  \n" +
            "Auth: access token in request header, refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> GetChatMessages(GetMessagesQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        [HttpPost]
        [SwaggerOperation(Description = "Sends message to particulat chat  \n" +
            "Auth: access token in request header, refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> SendMessage(SendMessageCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        [HttpPut]
        [SwaggerOperation(Description = "Updates particular message  \n" +
            "Requires to by an author of message  \n" +
            "Auth: access token in request header, refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> EditMessage(EditMessageCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        
        [Authorize]
        [HttpDelete]
        [SwaggerOperation(Description = "Deletes particular message  \n" +
            "Requires to by an author of message  \n" +
            "Auth: access token in request header, refresh token ID in cookies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> DeleteMessage(DeleteMessageCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
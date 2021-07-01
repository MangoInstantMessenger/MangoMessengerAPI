using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
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
        [HttpPost]
        [SwaggerOperation(Summary = "Sends message to particular chat.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> SendMessage(SendMessageCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        [HttpPut]
        [SwaggerOperation(Summary = "Updates particular message.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> EditMessage(EditMessageCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
        
        [Authorize]
        [HttpDelete]
        [SwaggerOperation(Summary = "Deletes particular message.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> DeleteMessage(DeleteMessageCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
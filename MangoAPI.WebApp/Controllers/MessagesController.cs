using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Queries.Messages;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessagesController : ControllerBase, IMessagesController
    {
        private readonly IMediator _mediator;
        private readonly UserManager<UserEntity> _userManager;

        public MessagesController(IMediator mediator, UserManager<UserEntity> userManager)
        {
            _mediator = mediator;
            _userManager = userManager;
        }

        [Authorize]
        [HttpGet]
        [SwaggerOperation(Summary = "Returns list of all messages of specified chat by chat ID.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> GetChatMessages(GetMessagesQuery query, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [Authorize]
        [HttpPost]
        [SwaggerOperation(Summary = "Sends message to particular chat.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> SendMessage(SendMessageCommand command, CancellationToken cancellationToken)
        {
            command.UserId = _userManager.GetUserId(User);
            return Ok(await _mediator.Send(command, cancellationToken));
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
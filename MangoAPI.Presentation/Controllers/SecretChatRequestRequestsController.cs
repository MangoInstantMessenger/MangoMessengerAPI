using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/secret-chat-requests")]
    [Produces("application/json")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SecretChatRequestRequestsController : ApiControllerBase, ISecretChatRequestsController
    {
        public SecretChatRequestRequestsController(IMediator mediator, IMapper mapper,
            RequestValidationService requestValidationService)
            : base(mediator, mapper, requestValidationService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetSecretChatRequests(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [HttpPost("{requestedUserId:guid}")]
        public async Task<IActionResult> CreateSecretChatRequest([FromRoute] Guid requestedUserId,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = new CreateSecretChatRequestCommand
            {
                RequestedUserId = requestedUserId,
                UserId = userId
            };

            return await RequestAsync(command, cancellationToken);
        }

        [HttpDelete("{requestId:guid}")]
        public async Task<IActionResult> ConfirmOrDeclineSecretChatRequest(Guid requestId, bool confirmed,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
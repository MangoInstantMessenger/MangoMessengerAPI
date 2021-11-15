using System;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Services;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/secret-chats")]
    [Produces("application/json")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class SecretChatsController : ApiControllerBase, ISecretChatsController
    {
        public SecretChatsController(IMediator mediator, IMapper mapper,
            RequestValidationService requestValidationService)
            : base(mediator, mapper, requestValidationService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetSecretChatRequests()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSecretChatRequest(Guid requestedUserId)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public async Task<IActionResult> ConfirmOrDeclineSecretChatRequest(Guid requestId, bool confirmed)
        {
            throw new NotImplementedException();
        }
    }
}
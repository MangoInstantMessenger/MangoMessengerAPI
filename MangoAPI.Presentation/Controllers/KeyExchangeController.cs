using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/key-exchange")]
    [Produces("application/json")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class KeyExchangeController : ApiControllerBase, IKeyExchangeController
    {
        public KeyExchangeController(IMediator mediator, IMapper mapper,
            RequestValidationService requestValidationService)
            : base(mediator, mapper, requestValidationService)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetKeyExchangeRequests(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> CreteKeyExchangeRequest([FromBody] CreateKeyExchangeRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var command = new CreateKeyExchangeRequestCommand
            {
                RequestedUserId = request.RequestedUserId,
                PublicKey = request.PublicKey,
                UserId = userId
            };

            return await RequestAsync(command, cancellationToken);
        }

        [HttpDelete]
        public async Task<IActionResult> ConfirmOrDeclineKeyExchangeRequest(
            [FromBody] ConfirmOrDeclineKeyExchangeRequest request,
            CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.KeyExchange;
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
        public KeyExchangeController(IMediator mediator, IMapper mapper) 
            : base(mediator, mapper)
        {
        }

        [HttpGet]
        public async Task<IActionResult> GetKeyExchangeRequests(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var request = new GetKeyExchangeRequestsQuery
            {
                UserId = userId
            };

            return await RequestAsync(request, cancellationToken);
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
            var userId = HttpContext.User.GetUserId();

            var command = new ConfirmOrDeclineKeyExchangeCommand
            {
                UserId = userId,
                Confirmed = request.Confirmed,
                PublicKey = request.PublicKey,
                RequestId = request.RequestId
            };

            return await RequestAsync(command, cancellationToken);
        }
    }
}
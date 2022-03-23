using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.OpenSslKeyExchange;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers;

[ApiController]
[Route("api/openssl-key-exchange-requests")]
[Produces("application/json")]
[Authorize]
public class OpenSslKeyExchangeController : ApiControllerBase, IOpenSslKeyExchangeController
{
    public OpenSslKeyExchangeController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
    {
    }

    [HttpPost("openssl-parameters")]
    public async Task<IActionResult> OpenSslCreateDiffieHellmanParameter([FromForm] IFormFile file,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new OpenSslCreateDiffieHellmanParameterCommand
        {
            UserId = userId,
            DiffieHellmanParameter = file
        };

        return await RequestAsync(command, cancellationToken);
    }

    [HttpGet("openssl-parameters")]
    public async Task<IActionResult> OpenSslGetDiffieHellmanParameter(CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(new OpenSslGetDhParametersQuery(), cancellationToken);
        var file = File(result.Response.FileContent, "text/plain", "dh_parameters.pem");

        return file;
    }

    [HttpPost("{userId:guid}")]
    public async Task<IActionResult> OpenSslCreateKeyExchangeRequest(
        [FromRoute] Guid userId,
        [FromForm] IFormFile senderPublicKey,
        CancellationToken cancellationToken)
    {
        var senderId = HttpContext.User.GetUserId();

        var command = new OpenSslCreateKeyExchangeCommand
        {
            ReceiverId = userId,
            SenderId = senderId,
            SenderPublicKey = senderPublicKey
        };

        return await RequestAsync(command, cancellationToken);
    }

    [HttpGet]
    public async Task<IActionResult> OpenSslGetKeyExchangeRequests(CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();
        var request = new OpenSslGetKeyExchangeRequestsQuery {UserId = userId};

        return await RequestAsync(request, cancellationToken);
    }

    [HttpPut("{requestId:guid}")]
    public async Task<IActionResult> OpenSslConfirmKeyExchangeRequest(
        [FromRoute] Guid requestId,
        [FromForm] IFormFile receiverPublicKey,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new OpenSslConfirmKeyExchangeCommand
        {
            RequestId = requestId,
            UserId = userId,
            ReceiverPublicKey = receiverPublicKey
        };

        return await RequestAsync(command, cancellationToken);
    }

    [HttpDelete("{requestId:guid}")]
    public async Task<IActionResult> OpenSslDeclineKeyExchangeRequest(
        [FromRoute] Guid requestId,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var request = new OpenSslDeclineKeyExchangeCommand
        {
            RequestId = requestId,
            UserId = userId,
        };

        return await RequestAsync(request, cancellationToken);
    }

    [HttpGet("public-keys/{requestId:guid}")]
    public async Task<IActionResult> OpenSslDownloadPartnerPublicKey(Guid requestId,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var query = new OpenSslDownloadPartnerPublicKeyQuery
        {
            UserId = userId,
            RequestId = requestId,
        };

        var result = await Mediator.Send(query, cancellationToken);

        var fileName = $"PUBLIC_KEY_{result.Response.PartnerId}";

        var file = File(result.Response.PublicKey, contentType: "text/plain", fileName);

        return file;
    }
}
using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.KeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.KeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for Key Exchange Request Entity
/// </summary>
[ApiController]
[Route("api/key-exchange")]
[Produces("application/json")]
[Authorize]
public class KeyExchangeController : ApiControllerBase, IKeyExchangeController
{
    public KeyExchangeController(IMediator mediator, IMapper mapper)
        : base(mediator, mapper)
    {
    }

    [HttpPost("openssl-parameters")]
    public async Task<IActionResult> OpenSslCreateDiffieHellmanParameter([FromForm] IFormFile file,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new CreateDiffieHellmanParameterCommand
        {
            UserId = userId,
            DiffieHellmanParameter = file
        };

        return await RequestAsync(command, cancellationToken);
    }

    [HttpGet("openssl-parameters")]
    public async Task<IActionResult> OpenSslGetDiffieHellmanParameter(CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(new GetDhParametersQuery(), cancellationToken);
        var file = File(result.Response.FileContent, "text/plain", "dh_parameters.pem");

        return file;
    }

    [HttpPost("openssl-key-exchange-requests/{userId:guid}")]
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

    [HttpGet("openssl-key-exchange-requests")]
    public async Task<IActionResult> OpenSslGetKeyExchangeRequests(CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();
        var request = new GetOpenSslKeyExchangeRequestsQuery {UserId = userId};

        return await RequestAsync(request, cancellationToken);
    }

    [HttpPut("openssl-key-exchange-requests/{requestId:guid}")]
    public async Task<IActionResult> OpenSslConfirmKeyExchangeRequest(
        [FromRoute] Guid requestId,
        [FromQuery] bool confirmed,
        [FromForm] IFormFile receiverPublicKey,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new OpenSslConfirmKeyExchangeCommand
        {
            RequestId = requestId,
            UserId = userId,
            Confirmed = confirmed,
            ReceiverPublicKey = receiverPublicKey
        };

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Returns all user's Diffie-Hellman key exchange requests.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpGet("cng-key-exchange-requests")]
    [SwaggerOperation(
        Summary = "Returns all user's key exchange requests.",
        Description = "Returns all user's Diffie-Hellman key exchange requests.")]
    [ProducesResponseType(typeof(GetKeyExchangeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CngGetKeyExchangeRequests(CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var request = new GetKeyExchangeRequestsQuery
        {
            UserId = userId
        };

        return await RequestAsync(request, cancellationToken);
    }

    /// <summary>
    /// Creates new Diffie-Hellman key exchange request with particular user.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpPost("cng-key-exchange-requests")]
    [SwaggerOperation(
        Summary = "Creates new key exchange request with particular user.",
        Description = "Creates new Diffie-Hellman key exchange request with particular user.")]
    [ProducesResponseType(typeof(CreateKeyExchangeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngCreteKeyExchangeRequest([FromBody] CreateKeyExchangeRequest request,
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

    /// <summary>
    /// Confirms or declines Diffie-Hellman key exchange request.
    /// </summary>
    /// <param name="request"></param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpDelete("cng-key-exchange-requests")]
    [SwaggerOperation(
        Summary = "Confirms or declines key exchange request.",
        Description = "Confirms or declines Diffie-Hellman key exchange request.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngConfirmOrDeclineKeyExchangeRequest(
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
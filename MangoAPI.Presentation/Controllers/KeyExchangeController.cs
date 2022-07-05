using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for OpenSSL Key Exchange Requests.
/// </summary>
[ApiController]
[Route("api/key-exchange-requests")]
[Produces("application/json")]
[Authorize]
public class KeyExchangeController : ApiControllerBase, IKeyExchangeController
{
    public KeyExchangeController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext)
        : base(mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Creates Diffie-Hellman parameter that is used by exchanging sides.
    /// </summary>
    /// <param name="file">IFormFile instance.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpPost("parameters")]
    [SwaggerOperation(
        Summary = "Downloads Diffie-Hellman parameter that is used by exchanging sides.",
        Description = "Creates Diffie-Hellman parameter that is used by exchanging sides.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(CreateDiffieHellmanParameterResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateDiffieHellmanParameter(
        [FromForm] IFormFile file,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new CreateDiffieHellmanParameterCommand(
            UserId: userId,
            DiffieHellmanParameter: file);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Downloads Diffie-Hellman parameter that is used by exchanging sides.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpGet("parameters")]
    [SwaggerOperation(
        Summary = "Downloads Diffie-Hellman parameter that is used by exchanging sides.",
        Description = "Downloads Diffie-Hellman parameter that is used by exchanging sides.")]
    [ProducesResponseType(typeof(GetDhParametersResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> DownloadDiffieHellmanParameter(CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(new GetDhParametersQuery(), cancellationToken);
        var file = File(result.Response.FileContent, "text/plain", "dh_parameters.pem");

        return file;
    }

    /// <summary>
    /// Creates Diffie-Hellman key exchange between two parties.
    /// </summary>
    /// <param name="userId">User GUID.</param>
    /// <param name="keyExchangeType">KeyExchangeType enum.</param>
    /// <param name="senderPublicKey">IFormFile instance.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpPost("{userId:guid}")]
    [SwaggerOperation(
        Summary = "Creates Diffie-Hellman key exchange between two parties.",
        Description = "Creates Diffie-Hellman key exchange between two parties.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(CreateKeyExchangeResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> CreateKeyExchangeRequest(
        [FromRoute] Guid userId,
        [FromQuery] KeyExchangeType keyExchangeType,
        [FromForm] IFormFile senderPublicKey,
        CancellationToken cancellationToken)
    {
        var senderId = CorrelationContext.GetUserId();

        var command =
            new CreateKeyExchangeCommand(
                userId,
                senderId,
                senderPublicKey,
                keyExchangeType);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Get all the user's key exchange requests.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get all the user's key exchange requests",
        Description = "Get all the user's key exchange requests")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(GetKeyExchangeRequestsResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetKeyExchangeRequests(CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var request = new GetKeyExchangeRequestsQuery(userId);

        return await RequestAsync(request, cancellationToken);
    }

    /// <summary>
    /// Confirm the key exchange by ID.
    /// </summary>
    /// <param name="requestId">Request ID.</param>
    /// <param name="receiverPublicKey">IFormFile receiverPublicKey.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpPut("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Confirm the key exchange by ID.",
        Description = "Confirm the key exchange by ID.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    public async Task<IActionResult> ConfirmKeyExchangeRequest(
        [FromRoute] Guid requestId,
        [FromForm] IFormFile receiverPublicKey,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new ConfirmKeyExchangeCommand(
            RequestId: requestId,
            UserId: userId,
            ReceiverPublicKey: receiverPublicKey);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Decline OpenSSL key exchange.
    /// </summary>
    /// <param name="requestId">Request ID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpDelete("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Decline key exchange.",
        Description = "Decline key exchange.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    public async Task<IActionResult> DeclineKeyExchangeRequest(
        [FromRoute] Guid requestId,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var request = new DeclineKeyExchangeCommand(requestId, userId);

        return await RequestAsync(request, cancellationToken);
    }

    /// <summary>
    /// Download partner public OpenSSL key.
    /// </summary>
    /// <param name="requestId">Request ID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpGet("public-keys/{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Download partner public key.",
        Description = "Download partner OpenSSL public key.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(DownloadPartnerPublicKeyResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> DownloadPartnerPublicKey(
        [FromRoute] Guid requestId,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var query = new DownloadPartnerPublicKeyQuery(userId, requestId);

        var result = await Mediator.Send(query, cancellationToken);

        var fileName = $"PUBLIC_KEY_{result.Response.PartnerId}";

        var file = File(result.Response.PublicKey, contentType: "text/plain", fileName);

        return file;
    }

    /// <summary>
    /// Get key exchange by ID.
    /// </summary>
    /// <param name="requestId">Request ID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    [HttpGet("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Get key exchange by ID.",
        Description = "Get key exchange by ID.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(GetKeyExchangeRequestByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetKeyExchangeRequestById(
        [FromRoute] Guid requestId,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var query = new GetKeyExchangeRequestByIdQuery(userId, requestId);

        return await RequestAsync(query, cancellationToken);
    }
}

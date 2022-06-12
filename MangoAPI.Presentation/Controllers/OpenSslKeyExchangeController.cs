using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.ApiQueries.DiffieHellmanKeyExchanges;
using MangoAPI.BusinessLogic.Responses;
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
[Route("api/openssl-key-exchange-requests")]
[Produces("application/json")]
[Authorize]
public class OpenSslKeyExchangeController : ApiControllerBase, IOpenSslKeyExchangeController
{
    public OpenSslKeyExchangeController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext) :
        base(mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Creates Diffie-Hellman parameter that is used by exchanging sides.
    /// </summary>
    /// <param name="file">IFormFile instance</param>
    /// <param name="cancellationToken">Cancellation token instance</param>
    /// <returns></returns>
    [HttpPost("openssl-parameters")]
    [SwaggerOperation(
        Summary = "Downloads Diffie-Hellman parameter that is used by exchanging sides.",
        Description = "Creates Diffie-Hellman parameter that is used by exchanging sides.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(CreateDiffieHellmanParameterResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslCreateDiffieHellmanParameter([FromForm] IFormFile file,
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
    /// <returns></returns>
    [HttpGet("openssl-parameters")]
    [SwaggerOperation(
        Summary = "Downloads Diffie-Hellman parameter that is used by exchanging sides.",
        Description = "Downloads Diffie-Hellman parameter that is used by exchanging sides.")]
    [ProducesResponseType(typeof(GetDhParametersResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslGetDiffieHellmanParameter(CancellationToken cancellationToken)
    {
        var result = await Mediator.Send(new GetDhParametersQuery(), cancellationToken);
        var file = File(result.Response.FileContent, "text/plain", "dh_parameters.pem");

        return file;
    }

    /// <summary>
    /// Creates Diffie-Hellman key exchange between two parties.
    /// </summary>
    /// <param name="userId">User GUID</param>
    /// <param name="senderPublicKey">IFormFile instance</param>
    /// <param name="cancellationToken">Cancellation token instance</param>
    /// <returns></returns>
    [HttpPost("{userId:guid}")]
    [SwaggerOperation(
        Summary = "Creates Diffie-Hellman key exchange between two parties.",
        Description = "Creates Diffie-Hellman key exchange between two parties.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(CreateKeyExchangeResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslCreateKeyExchangeRequest(
        [FromRoute] Guid userId,
        [FromForm] IFormFile senderPublicKey,
        CancellationToken cancellationToken)
    {
        var senderId = CorrelationContext.GetUserId();

        var command =
            new CreateKeyExchangeCommand(
                ReceiverId: userId,
                SenderId: senderId,
                SenderPublicKey: senderPublicKey);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Get OpenSSL key exchange requests.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpGet]
    [SwaggerOperation(
        Summary = "Get key exchange requests.",
        Description = "Get OpenSSL exchange requests.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(GetKeyExchangeRequestsResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslGetKeyExchangeRequests(CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var request = new GetKeyExchangeRequestsQuery(userId);

        return await RequestAsync(request, cancellationToken);
    }

    /// <summary>
    /// Confirm OpenSSL key exchange.
    /// </summary>
    /// <param name="requestId">Request ID.</param>
    /// <param name="receiverPublicKey"></param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpPut("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Confirm key exchange.",
        Description = "Confirm OpenSSL key exchange.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslConfirmKeyExchangeRequest(
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
    /// <returns></returns>
    [HttpDelete("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Decline key exchange.",
        Description = "Decline OpenSSL key exchange.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslDeclineKeyExchangeRequest(
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
    /// <param name="keyExchangeType"></param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpGet("public-keys/{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Download partner public key.",
        Description = "Download partner OpenSSL public key.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(DownloadPartnerPublicKeyResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslDownloadPartnerPublicKey(
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
    /// Get OpenSSL key exchange by ID.
    /// </summary>
    /// <param name="requestId">Request ID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpGet("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Get key exchange by ID.",
        Description = "Get OpenSSL key exchange by ID.")]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    [ProducesResponseType(typeof(GetKeyExchangeRequestByIdResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> OpenSslGetKeyExchangeRequestById([FromRoute] Guid requestId,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var query = new GetKeyExchangeRequestByIdQuery(userId, requestId);

        return await RequestAsync(query, cancellationToken);
    }
}
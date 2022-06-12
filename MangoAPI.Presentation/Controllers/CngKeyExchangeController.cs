using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for CNG Key Exchange Requests.
/// </summary>
[ApiController]
[Route("api/cng-key-exchange-requests")]
[Produces("application/json")]
[Authorize]
public class CngKeyExchangeController : ApiControllerBase, ICngKeyExchangeController
{
    public CngKeyExchangeController(
        IMediator mediator,
        IMapper mapper,
        ICorrelationContext correlationContext) : base(mediator, mapper, correlationContext)
    {
    }

    /// <summary>
    /// Returns all user's Diffie-Hellman key exchange requests.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpGet]
    [SwaggerOperation(
        Summary = "Returns all user's key exchange requests.",
        Description = "Returns all user's Diffie-Hellman key exchange requests.")]
    [ProducesResponseType(typeof(CngGetKeyExchangeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> CngGetKeyExchangeRequests(CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var request = new CngGetKeyExchangeRequestsQuery(userId);

        return await RequestAsync(request, cancellationToken);
    }

    /// <summary>
    /// Creates new Diffie-Hellman key exchange request with particular user.
    /// </summary>
    /// <param name="senderPublicKey"></param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <param name="receiverId"></param>
    /// <returns></returns>
    [HttpPost("{receiverId:guid}")]
    [SwaggerOperation(
        Summary = "Creates new key exchange request with particular user.",
        Description = "Creates new Diffie-Hellman key exchange request with particular user.")]
    [ProducesResponseType(typeof(CngCreateKeyExchangeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngCreteKeyExchangeRequest(
        [FromRoute] Guid receiverId,
        [FromForm] IFormFile senderPublicKey,
        CancellationToken cancellationToken)
    {
        var senderId = CorrelationContext.GetUserId();

        var command = new CngCreateKeyExchangeRequestCommand(senderId, receiverId, senderPublicKey);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Confirms Diffie-Hellman key exchange request by ID.
    /// </summary>
    /// <param name="requestId"></param>
    /// <param name="receiverPublicKey"></param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpPut("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Confirms Diffie-Hellman key exchange request by ID.",
        Description = "Confirms Diffie-Hellman key exchange request by ID.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngConfirmKeyExchangeRequest(
        [FromRoute] Guid requestId,
        [FromForm] IFormFile receiverPublicKey,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var command = new CngConfirmKeyExchangeCommand(userId, requestId, receiverPublicKey);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Return Diffie-Hellman key exchange request by ID. Returns error if key exchange request not belongs to current user
    /// </summary>
    /// <param name="requestId">Diffie-Hellman key exchange request ID</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns></returns>
    [HttpGet("{requestId:guid}")]
    [SwaggerOperation(
        Summary = "Returns key exchange request by ID",
        Description =
            "Return Diffie-Hellman key exchange request by ID. Returns error if key exchange request not belongs " +
            "to current user")]
    [ProducesResponseType(typeof(CngGetKeyExchangeRequestByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngGetKeyExchangeRequestById(Guid requestId, CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var query = new CngGetKeyExchangeRequestByIdQuery(userId, requestId);

        return await RequestAsync(query, cancellationToken);
    }
}
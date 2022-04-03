using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;
using MangoAPI.BusinessLogic.ApiQueries.CngKeyExchange;
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
/// Controller responsible for CNG Key Exchange Requests.
/// </summary>
[ApiController]
[Route("api/cng-key-exchange-requests")]
[Produces("application/json")]
[Authorize]
public class CngKeyExchangeController : ApiControllerBase, ICngKeyExchangeController
{
    public CngKeyExchangeController(IMediator mediator, IMapper mapper)
        : base(mediator, mapper)
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
        var userId = HttpContext.User.GetUserId();

        var request = new CngGetKeyExchangeRequestsQuery
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
    [HttpPost]
    [SwaggerOperation(
        Summary = "Creates new key exchange request with particular user.",
        Description = "Creates new Diffie-Hellman key exchange request with particular user.")]
    [ProducesResponseType(typeof(CngCreateKeyExchangeResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngCreteKeyExchangeRequest([FromBody] CngCreateKeyExchangeRequest request,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new CngCreateKeyExchangeRequestCommand
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
    [HttpDelete]
    [SwaggerOperation(
        Summary = "Confirms or declines key exchange request.",
        Description = "Confirms or declines Diffie-Hellman key exchange request.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngConfirmOrDeclineKeyExchangeRequest(
        [FromBody] CngConfirmOrDeclineKeyExchangeRequest request,
        CancellationToken cancellationToken)
    {
        var userId = HttpContext.User.GetUserId();

        var command = new CngConfirmOrDeclineKeyExchangeCommand
        {
            UserId = userId,
            Confirmed = request.Confirmed,
            PublicKey = request.PublicKey,
            RequestId = request.RequestId
        };

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
        Description = "Return Diffie-Hellman key exchange request by ID. Returns error if key exchange request not belongs " +
                      "to current user")]
    [ProducesResponseType(typeof(CngGetKeyExchangeRequestByIdResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> CngGetKeyExchangeRequestById(Guid requestId, CancellationToken cancellationToken)
    {
        var query = new CngGetKeyExchangeRequestByIdQuery
        {
            UserId = HttpContext.User.GetUserId(),
            RequestId = requestId
        };

        return await RequestAsync(query, cancellationToken);
    }
}
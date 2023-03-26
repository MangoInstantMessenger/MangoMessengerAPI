﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Controller responsible for Sessions Entity.
/// </summary>
[ApiController]
[Route("api/sessions")]
public class SessionsController : ApiControllerBase<SessionsController>, ISessionsController
{
    public SessionsController(
        IMediator mediator,
        IMapper mapper,
        ICorrelationContext correlationContext,
        ILogger<SessionsController> logger)
        : base(mediator, mapper, correlationContext, logger)
    {
    }

    /// <summary>
    /// Logins to the system. Returns pair of the access/refresh tokens.
    /// </summary>
    /// <param name="request">LoginRequest instance.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPost]
    [AllowAnonymous]
    [SwaggerOperation(
        Description = "Logins to the system. Returns pair of the access/refresh tokens.",
        Summary = "Logins to the system.")]
    [ProducesResponseType(typeof(TokensResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> LoginAsync(
        [FromBody] LoginRequest request,
        CancellationToken cancellationToken)
    {
        var command = Mapper.Map<LoginCommand>(request);
        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Refreshes current user's session. Returns pair of the access/refresh tokens. Requires valid refresh token.
    /// </summary>
    /// <param name="refreshToken">Refresh Token ID, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [AllowAnonymous]
    [HttpPost("{refreshToken:guid}")]
    [SwaggerOperation(
        Description = "Refreshes current user's session. " +
                      "Returns pair of the access/refresh tokens. " +
                      "Requires valid refresh token. Allow anonymous.",
        Summary = "Refreshes current user's session.")]
    [ProducesResponseType(typeof(TokensResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> RefreshSession(
        [FromRoute] Guid refreshToken,
        CancellationToken cancellationToken)
    {
        var command = new RefreshSessionCommand(refreshToken);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Deletes current user's session.
    /// </summary>
    /// <param name="refreshToken">Refresh Token ID, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpDelete("{refreshToken:guid}")]
    [Authorize]
    [SwaggerOperation(
        Description = "Deletes current user's session.",
        Summary = "Deletes current user's session.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> LogoutAsync(
        [FromRoute] Guid refreshToken,
        CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var command = new LogoutCommand(userId, refreshToken);

        return await RequestAsync(command, cancellationToken);
    }
}
﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
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
/// Controller responsible for Contacts Entity.
/// </summary>
[ApiController]
[Route("api/contacts")]
[Authorize]
public class ContactsController : ApiControllerBase<ContactsController>, IContactsController
{
    public ContactsController(
        IMediator mediator,
        IMapper mapper,
        ICorrelationContext correlationContext,
        ILogger<ContactsController> logger)
        : base(mediator, mapper, correlationContext, logger)
    {
    }

    /// <summary>
    /// Adds particular user to the contacts by User ID.
    /// </summary>
    /// <param name="contactId">User ID to add, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpPost("{contactId:guid}")]
    [SwaggerOperation(
        Description = "Adds particular user to the contacts by User ID.",
        Summary = "Adds particular user to the contacts")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> AddContact([FromRoute] Guid contactId, CancellationToken cancellationToken)
    {
        var currentUserId = CorrelationContext.GetUserId();

        var command = new AddContactCommand(currentUserId, contactId);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Deletes particular contact from the contacts by User ID.
    /// </summary>
    /// <param name="contactId">User ID to add, UUID.</param>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpDelete("{contactId:guid}")]
    [SwaggerOperation(
        Description = "Deletes particular contact from the contacts by User ID. ",
        Summary = "Deletes particular contact from the contacts.")]
    [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
    public async Task<IActionResult> DeleteContact(
        [FromRoute] Guid contactId,
        CancellationToken cancellationToken)
    {
        var currentUserId = CorrelationContext.GetUserId();
        var command = new DeleteContactCommand(currentUserId, contactId);

        return await RequestAsync(command, cancellationToken);
    }

    /// <summary>
    /// Returns list of current user's contacts.
    /// </summary>
    /// <param name="cancellationToken">Cancellation token instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpGet]
    [SwaggerOperation(
        Description = "Returns list of current user's contacts.",
        Summary = "Returns list of user's contacts.")]
    [ProducesResponseType(typeof(GetContactsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> GetContacts(CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();

        var query = new GetContactsQuery(userId);

        return await RequestAsync(query, cancellationToken);
    }

    /// <summary>
    /// Searches user by display name.
    /// </summary>
    /// <param name="searchQuery">Search query string.</param>
    /// <param name="cancellationToken">CancellationToken instance.</param>
    /// <returns>Possible codes: 200, 400, 409.</returns>
    [HttpGet("searches")]
    [SwaggerOperation(
        Description = "Searches user by display name.",
        Summary = "Searches user by display name.")]
    [ProducesResponseType(typeof(SearchContactResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> SearchesAsync(
        [FromQuery] string searchQuery,
        CancellationToken cancellationToken)
    {
        var currentUserId = CorrelationContext.GetUserId();

        var query = new SearchContactQuery(searchQuery, currentUserId);

        return await RequestAsync(query, cancellationToken);
    }
}
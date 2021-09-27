using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.ApiQueries.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for Contacts Entity.
    /// </summary>
    [ApiController]
    [Route("api/contacts")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ContactsController : ApiControllerBase, IContactsController
    {
        public ContactsController(IMediator mediator, IMapper mapper) : base(mediator, mapper)
        {
        }

        /// <summary>
        /// Adds particular user to the contacts. Fetches user by user ID. Requires role: User.
        /// </summary>
        /// <param name="contactId">User ID to add, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("{contactId:guid}")]
        [SwaggerOperation(Description = "Adds particular user to the contacts. Fetches user by user ID. " +
            "Requires role: User.", Summary = "Adds particular user to the contacts")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> AddContact([FromRoute] Guid contactId, CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();

            var command = new AddContactCommand
            {
                UserId = currentUserId,
                ContactId = contactId,
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Deletes particular contact from the contacts. Fetches user by user ID. Requires role: User
        /// </summary>
        /// <param name="contactId">User ID to add, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpDelete("{contactId:guid}")]
        [SwaggerOperation(Description = "Deletes particular contact from the contacts. Fetches user by user ID. " +
            "Requires role: User",
            Summary = "Deletes particular contact from the contacts.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> DeleteContact([FromRoute] Guid contactId,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();
            var command = new DeleteContactCommand
            {
                UserId = currentUserId,
                ContactId = contactId,
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Returns list of current user's contacts. Requires role: User.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet]
        [SwaggerOperation(Description = "Returns list of current user's contacts. Requires role: User.",
            Summary = "Returns list of user's contacts.")]
        [ProducesResponseType(typeof(GetContactsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> GetContacts(CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();

            var query = new GetContactsQuery
            {
                UserId = userId
            };

            return await RequestAsync(query, cancellationToken);
        }

        /// <summary>
        /// Searches user by his display name. Requires role: User.
        /// </summary>
        /// <param name="searchQuery">Search query string.</param>
        /// <param name="cancellationToken">CancellationToken instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpGet("searches")]
        [Authorize(Roles = "User")]
        [SwaggerOperation(Description =
            "Searches user by display name, phone number or e-mail address. Requires role: User.",
            Summary = "Searches user by credential.")]
        [ProducesResponseType(typeof(SearchContactResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> SearchesAsync([FromQuery] string searchQuery,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();

            var query = new SearchContactQuery
            {
                SearchQuery = searchQuery,
                UserId = currentUserId
            };

            return await RequestAsync(query, cancellationToken);
        }
    }
}
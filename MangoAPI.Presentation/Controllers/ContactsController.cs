namespace MangoAPI.Presentation.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessLogic.ApiCommands.Contacts;
    using BusinessLogic.ApiQueries.Contacts;
    using BusinessLogic.Responses;
    using Extensions;
    using Interfaces;
    using MediatR;
    using Microsoft.AspNetCore.Authentication.JwtBearer;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Swashbuckle.AspNetCore.Annotations;

    /// <summary>
    /// Controller responsible for Contacts Entity.
    /// </summary>
    [ApiController]
    [Route("api/contacts")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ContactsController : ApiControllerBase, IContactsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsController"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        public ContactsController(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Adds particular user to the contacts. Fetches user by user ID. Requires role: User.
        /// </summary>
        /// <param name="contactId">User ID to add, UUID.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPost("{contactId}")]
        [SwaggerOperation(Summary = "Adds particular user to the contacts. Fetches user by user ID. " +
                                    "Requires role: User.")]
        [ProducesResponseType(typeof(AddContactResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> AddContact([FromRoute] string contactId, CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();
            var command = new AddContactCommand
            {
                UserId = currentUserId,
                ContactId = contactId,
            };

            return await RequestAsync(command, cancellationToken);
        }

        [HttpDelete("{contactId}")]
        [SwaggerOperation(Summary = "Deletes particular contact from the contacts. Fetches user by user ID. " +
                                    "Requires role: User")]
        [ProducesResponseType(typeof(DeleteContactResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> DeleteContact([FromRoute] string contactId,
            CancellationToken cancellationToken)
        {
            var currentUserId = HttpContext.User.GetUserId();
            var command = new DeleteContactCommand()
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
        [SwaggerOperation(Summary = "Returns list of current user's contacts. Requires role: User.")]
        [ProducesResponseType(typeof(GetContactsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetContacts(CancellationToken cancellationToken)
        {
            var query = new GetContactsQuery { UserId = HttpContext.User.GetUserId() };

            return await RequestAsync(query, cancellationToken);
        }
    }
}

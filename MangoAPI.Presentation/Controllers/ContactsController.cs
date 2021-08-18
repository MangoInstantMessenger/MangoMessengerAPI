using System.Threading;
using System.Threading.Tasks;
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

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    [Authorize(Roles = "User", AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class ContactsController : ApiControllerBase, IContactsController
    {
        public ContactsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("{contactId}")]
        [SwaggerOperation(Summary = "Adds new contact.")]
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
                ContactId = contactId
            };

            return await RequestAsync(command, cancellationToken);
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Returns list of current user's contacts.")]
        [ProducesResponseType(typeof(GetContactsResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> GetContacts(CancellationToken cancellationToken)
        {
            var query = new GetContactsQuery {UserId = HttpContext.User.GetUserId()};

            return await RequestAsync(query, cancellationToken);
        }
    }
}
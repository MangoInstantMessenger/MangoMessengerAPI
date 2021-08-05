using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.Contacts;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.Contacts;
using MangoAPI.WebApp.Extensions;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/contacts")]
    public class ContactsController : ApiControllerBase, IContactsController
    {
        public ContactsController(IMediator mediator) : base(mediator)
        {
        }

        [Authorize]
        [HttpPost]
        [SwaggerOperation(Summary = "Adds new contact")]
        [ProducesResponseType(typeof(AddContactResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> AddContact([FromBody]AddContactRequest request,
            CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);
            
            return await RequestAsync(command, cancellationToken);
        }
    }
}
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserInformation;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.BusinessLogic.Responses.UserInformation;
using MangoAPI.Presentation.Extensions;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.Presentation.Controllers
{
    [ApiController]
    [Route("api/personal-information")]
    public class UserInformationController : ApiControllerBase, IUserInformationController
    {
        public UserInformationController(IMediator mediator) : base(mediator)
        {
        }

        [Authorize]
        [HttpPut]
        [SwaggerOperation(Summary = "Updates user's personal information")]
        [ProducesResponseType(typeof(UpdateUserInformationResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> UpdateUserInformation(UpdateUserInformationRequest request, CancellationToken cancellationToken)
        {
            var userId = HttpContext.User.GetUserId();
            var command = request.ToCommand(userId);

            return await RequestAsync(command, cancellationToken);
        }
    }
}
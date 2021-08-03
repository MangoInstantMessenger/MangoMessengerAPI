using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.UserInformation;
using MangoAPI.DTO.Responses;
using MangoAPI.DTO.Responses.UserInformation;
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
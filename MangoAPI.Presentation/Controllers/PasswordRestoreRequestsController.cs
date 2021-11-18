using AutoMapper;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Controller responsible for Password Restore Request Entity.
    /// </summary>
    [ApiController]
    [Route("api/password-restore-request")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class PasswordRestoreRequestsController : ApiControllerBase, IPasswordRestoreRequestsController
    {
        public PasswordRestoreRequestsController(IMediator mediator, IMapper mapper)
            : base(mediator, mapper)
        {
        }

        /// <summary>
        /// Creates new password restore request in database.
        /// </summary>
        /// <param name="emailOrPhone">Email or phone of user.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("{emailOrPhone}")]
        [SwaggerOperation(Description = "Creates new password restore request in database. Allow anonymous.",
            Summary = "Creates new password restore request in database.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RestorePasswordRequestAsync([FromRoute] string emailOrPhone,
            CancellationToken cancellationToken)
        {
            var command = new RequestPasswordRestoreCommand
            {
                EmailOrPhone = emailOrPhone
            };

            return await RequestAsync(command, cancellationToken);
        }

        /// <summary>
        /// Updates users password hash in database.
        /// </summary>
        /// <param name="request">Request instance.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>Possible codes: 200, 400, 409.</returns>
        [HttpPut]
        [AllowAnonymous]
        [SwaggerOperation(Description = "Updates users password hash in database. Allow anonymous.",
            Summary = "Updates users password hash in database.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        public async Task<IActionResult> RestorePasswordAsync([FromBody] PasswordRestoreRequest request,
            CancellationToken cancellationToken)
        {
            var command = Mapper.Map<PasswordRestoreCommand>(request);

            return await RequestAsync(command, cancellationToken);
        }
    }
}
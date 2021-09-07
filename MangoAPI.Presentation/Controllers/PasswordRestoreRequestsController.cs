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
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordRestoreRequestsController"/> class.
        /// </summary>
        /// <param name="mediator">Instance of mediator.</param>
        public PasswordRestoreRequestsController(IMediator mediator) : base(mediator)
        { }

        /// <summary>
        /// Creates new password restore request in database.
        /// </summary>
        /// <param name="emailOrPhone">Email or phone of user.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("{emailOrPhone}")]
        [SwaggerOperation(Summary = "Creates new password restore request in database.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RestorePasswordRequestAsync(string emailOrPhone, CancellationToken cancellationToken)
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
        [SwaggerOperation(Summary = "Updates users password hash in database.")]
        [ProducesResponseType(typeof(ResponseBase), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ErrorResponse), StatusCodes.Status409Conflict)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> RestorePasswordAsync(PasswordRestoreRequest request,
            CancellationToken cancellationToken)
        {
            var command = request.ToCommand();

            return await RequestAsync(command, cancellationToken);
        }
    }
}
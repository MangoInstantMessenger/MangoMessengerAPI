using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase, IUsersController
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Authorize]
        [HttpGet("{userId}")]
        [SwaggerOperation(Summary = "Returns information about particular user.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> FindUser([FromRoute] string userId, CancellationToken cancellationToken)
        {
            var query = new FindUserQuery {UserId = userId};
            var response = await _mediator.Send(query, cancellationToken);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
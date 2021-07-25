using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.QueryModels.Users;
using MangoAPI.DTO.Responses.Users;
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
    public class UsersController : ApiControllerBase, IUsersController
    {
        public UsersController(IMediator mediator) : base(mediator)
        {
        }

        [Authorize]
        [HttpGet("{userId}")]
        [SwaggerOperation(Summary = "Returns information about particular user.")]
        [ProducesResponseType(typeof(FindUserResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(FindUserResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> FindUser([FromRoute] string userId, CancellationToken cancellationToken)
        {
            var query = new FindUserQueryModel {UserId = userId};
            return await RequestAsync(query, cancellationToken);
        }
    }
}
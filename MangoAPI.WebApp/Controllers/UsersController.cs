using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using MangoAPI.WebApp.Interfaces;
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
        [Authorize]
        [HttpGet("{userId}")]
        [SwaggerOperation(Summary = "Returns information about particular user.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public Task<IActionResult> FindUser([FromRoute] string userId, CancellationToken cancellationToken)
        {
            var query = new FindUserQuery {UserId = userId};
            throw new NotImplementedException();
        }
    }
}
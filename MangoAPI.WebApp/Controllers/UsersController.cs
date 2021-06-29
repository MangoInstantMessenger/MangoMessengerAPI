using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase, IUsersController
    {
        [Authorize]
        [HttpGet]
        public Task<IActionResult> FindUser(FindUserQuery query, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using MangoAPI.WebApp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase, IUsersController
    {
        [HttpGet]
        public Task<IActionResult> FindUser(FindUserQuery query)
        {
            throw new System.NotImplementedException();
        }
    }
}
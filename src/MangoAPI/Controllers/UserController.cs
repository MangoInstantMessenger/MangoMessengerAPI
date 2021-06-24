using System.Threading.Tasks;
using MangoAPI.User.Login;
using MangoAPI.User.Registration;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("login")]
        public async Task<ActionResult<User.User>> LoginAsync(LoginQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost("registration")]
        public async Task<ActionResult<User.User>> RegistrationAsync(RegistrationCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
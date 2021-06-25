using System.Threading.Tasks;
using MangoAPI.DTO.Commands;
using MangoAPI.DTO.Models;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
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
        public async Task<ActionResult<User>> LoginAsync(LoginCommand command)
        {
            return await _mediator.Send(command);
        }

        [HttpPost("registration")]
        public async Task<ActionResult<User>> RegistrationAsync(RegistrationCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
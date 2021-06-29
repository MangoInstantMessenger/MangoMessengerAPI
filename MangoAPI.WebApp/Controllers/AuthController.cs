using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Common;
using MangoAPI.Application.Services;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.Infrastructure.Database;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Swashbuckle.AspNetCore.Annotations;

namespace MangoAPI.WebApp.Controllers
{
    /// <summary>
    /// Controller responsible for user authentication process.
    /// </summary>
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase, IAuthController
    {
        private readonly IMediator _mediator;
        private readonly MangoPostgresDbContext _postgresDbContext;
        
        
        public AuthController(IMediator mediator,
            MangoPostgresDbContext postgresDbContext)
        {
            _mediator = mediator;
            _postgresDbContext = postgresDbContext;
        }

        [AllowAnonymous]
        [HttpPost("login")]
        [SwaggerOperation(Summary = "Performs login to the messenger. Returns: Access token, Refresh Token ID.")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand command)
        {
            var response = await _mediator.Send(command);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpPost("confirm-register")]
        public async Task<IActionResult> ConfirmRegisterAsync([FromBody] ConfirmRegisterCommand command)
        {
            var response = await _mediator.Send(command);
            if (!response.Success) return BadRequest(response);
            return Ok(response);
        }

        [AllowAnonymous]
        [HttpGet("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync()
        {
            var command = new RefreshTokenCommand();
            var result = await _mediator.Send(command);
            if (!result.Success) return BadRequest(result);

            // _cookieService.Set("MangoRefreshToken", result.RefreshTokenId,
            //     7);

            return Ok(result);
        }

        [Authorize]
        [HttpPost("logout")]
        public async Task<IActionResult> LogoutAsync([FromBody] LogoutCommand command,
            CancellationToken cancellationToken)
        {
            return Ok(await _mediator.Send(command, cancellationToken));
        }
    }
}
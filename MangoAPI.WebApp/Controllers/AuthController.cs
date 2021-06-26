using System;
using System.Security.Claims;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MangoAPI.WebApp.Controllers
{
    /// <summary>
    /// Controller responsible for user authentication process.
    /// </summary>
    [ApiController]
    [AllowAnonymous]
    [Route("api/auth")]
    public class AuthController : ControllerBase, IAuthController
    {
        private readonly IMediator _mediator;
        private readonly ICookieService _cookieService;
        private readonly MangoPostgresDbContext _postgresDbContext;

        public AuthController(IMediator mediator, ICookieService cookieService,
            MangoPostgresDbContext postgresDbContext)
        {
            _mediator = mediator;
            _cookieService = cookieService;
            _postgresDbContext = postgresDbContext;
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync([FromBody] LoginCommand command)
        {
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;

            if (ipAddress == null)
            {
                return BadRequest("Cannot catch an IP Address");
            }

            command.IpAddress = ipAddress.MapToIPv4().ToString();

            var response = await _mediator.Send(command);

            if (!response.Success)
            {
                return BadRequest(response);
            }

            _cookieService.Set(Response, "MangoRefreshToken", response.RefreshToken, 7);

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync([FromBody] RegisterCommand command)
        {
            var response = await _mediator.Send(command);

            if (response.AlreadyRegistered || !response.TermsAccepted)
            {
                return BadRequest(response);
            }

            _cookieService.Set(Response, "MangoRegisterRequest",
                new Random().Next(1000).ToString(), 10);

            return Ok(response);
        }

        [HttpPost("confirm-register")]
        public async Task<IActionResult> ConfirmRegisterAsync([FromBody] ConfirmRegisterCommand command)
        {
            var response = await _mediator.Send(command);

            var cookie = _cookieService.Get(Request, "MangoRegisterRequest");

            if (cookie == null)
            {
                return BadRequest("Invalid or expired cookies.");
            }

            if (!response.Success)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
        
        [Authorize]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync()
        {
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;

            var identity = User.Identity as ClaimsIdentity;
            
            if (ipAddress == null)
            {
                return BadRequest("Invalid Ip Address.");
            }
            
            var cookieToken = _cookieService.Get(Request, "MangoRefreshToken");
            
            if (cookieToken == null)
            {
                return BadRequest("Invalid Refresh Token.");
            }

            var tokenEntity = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x => x.Token == cookieToken);
            
            if (tokenEntity == null)
            {
                return BadRequest("Invalid Refresh Token.");
            }

            var command = new RefreshTokenCommand
            {
                RefreshToken = tokenEntity.Token, 
                IpAddress = ipAddress.MapToIPv4().ToString()
            };

            var result = await _mediator.Send(command);

            if (!result.Success)
            {
                return BadRequest(result);
            }
            
            _cookieService.Set(Response, "MangoRefreshToken", result.RefreshToken, 7);

            return Ok(result);
        }
    }
}
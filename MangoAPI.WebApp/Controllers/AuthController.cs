using System;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.Infrastructure.Database;
using MangoAPI.Infrastructure.Interfaces;
using MangoAPI.WebApp.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

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
        private readonly ICookieService _cookieService;
        private readonly MangoPostgresDbContext _postgresDbContext;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ISecurityTokenValidator _securityTokenValidator;

        public AuthController(IMediator mediator, 
            ICookieService cookieService,
            MangoPostgresDbContext postgresDbContext, 
            IHttpContextAccessor httpContextAccessor,
            ISecurityTokenValidator securityTokenValidator)
        {
            _mediator = mediator;
            _cookieService = cookieService;
            _postgresDbContext = postgresDbContext;
            _httpContextAccessor = httpContextAccessor;
            _securityTokenValidator = securityTokenValidator;
        }

        [AllowAnonymous]
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

        [AllowAnonymous]
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

        [AllowAnonymous]
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

        [AllowAnonymous]
        [HttpPost("refresh-token")]
        public async Task<IActionResult> RefreshTokenAsync()
        {
            var token = _httpContextAccessor
                .HttpContext?
                .Request.Headers["Authorization"]
                .ToString()
                .Replace("Bearer ", string.Empty);

            var principal = _securityTokenValidator
                .ValidateToken(token, null, out var checkToken);

            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;

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
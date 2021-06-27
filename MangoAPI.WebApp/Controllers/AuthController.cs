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
            // TODO: add user's refresh token verification here
            
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            if (ipAddress == null) return BadRequest("Cannot fetch an IP Address.");

            var userAgent = Request.Headers["User-Agent"].ToString();
            if (userAgent == null) return BadRequest("Cannot fetch User Agent.");

            command.IpAddress = ipAddress.MapToIPv6().ToString();
            command.UserAgent = userAgent;
            
            var response = await _mediator.Send(command);
            if (!response.Success) return BadRequest(response);

            _cookieService.Set(Response, "MangoRefreshToken", response.RefreshTokenId, 7);

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
        public async Task<IActionResult> RefreshTokenAsync([FromBody] RefreshTokenCommand command)
        {
            var cookieToken = _cookieService.Get(Request, "MangoRefreshToken");
            
            var parsed = Guid.TryParse(cookieToken, out _);
            if (!parsed) return BadRequest("Invalid Refresh Token.");

            var tokenEntity = await _postgresDbContext.RefreshTokens
                .FirstOrDefaultAsync(x => x.Id == cookieToken);
            
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            if (ipAddress == null) return BadRequest("Cannot fetch an IP Address.");

            var userAgent = Request.Headers["User-Agent"].ToString();
            if (userAgent == null) return BadRequest("Cannot fetch User Agent.");

            if (tokenEntity == null) return BadRequest("Invalid Refresh Token.");
            
            command.RefreshTokenId = tokenEntity.Id;
            command.IpAddress = ipAddress.MapToIPv6().ToString();
            command.UserAgent = userAgent;

            var result = await _mediator.Send(command);
            if (!result.Success) return BadRequest(result);

            _cookieService.Set(Response, "MangoRefreshToken", result.RefreshTokenId, 7);

            return Ok(result);
        }
    }
}
using System;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Models;
using MangoAPI.Infrastructure.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICookieService _cookieService;

        public AuthController(IMediator mediator, ICookieService cookieService)
        {
            _mediator = mediator;
            _cookieService = cookieService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> LoginAsync([FromBody] LoginCommand command)
        {
            return await _mediator.Send(command);
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
    }
}
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    [ApiController]
    public class ApiContollerBase : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApiContollerBase(IMediator mediator) => _mediator = mediator;

        [NonAction]
        public async Task<IActionResult> CommandAsync<T>(IRequest<T> request,
            CancellationToken cancellationToken)
            where T : ResponseBase
        {
            var response = await _mediator.Send(request, cancellationToken);

            if (response.Success)
            {
                return Ok(response);
            }

            return response.ErrorMessage.StatusCode switch
            {
                StatusCodes.Status404NotFound => NotFound(response),
                StatusCodes.Status409Conflict => Conflict(response),
                _ => throw new InvalidDataException($"Invalid status code [{response.ErrorMessage.StatusCode}]")
            };
        }
    }
}
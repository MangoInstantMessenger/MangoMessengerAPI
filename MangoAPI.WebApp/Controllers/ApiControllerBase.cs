using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        [NonAction]
        protected async Task<IActionResult> RequestAsync<T>(IRequest<T> request, CancellationToken cancellationToken)
            where T : ResponseBase
        {
            var response = await _mediator.Send(request, cancellationToken);

            if (!response.Success)
            {
                return Conflict(response);
            }

            return Ok(response);
        }
    }
}
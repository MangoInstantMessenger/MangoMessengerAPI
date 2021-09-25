using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Base controller class. Encapsulates common logic.
    /// </summary>
    public class ApiControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;
        protected readonly IMapper Mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiControllerBase"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        /// <param name="mapper">Automapper instance.</param>
        public ApiControllerBase(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            Mapper = mapper;
        }

        /// <summary>
        /// Common request logic over all controllers.
        /// </summary>
        /// <typeparam name="T">Generic data type.</typeparam>
        /// <param name="request">Generic request type.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
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

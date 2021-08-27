namespace MangoAPI.Presentation.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using BusinessLogic.Responses;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Base controller class. Encapsulates common logics.
    /// </summary>
    public class ApiControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiControllerBase"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        public ApiControllerBase(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Common request logics over all controllers.
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

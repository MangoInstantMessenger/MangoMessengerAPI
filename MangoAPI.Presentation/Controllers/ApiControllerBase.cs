using System.Net;
using AutoMapper;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.Application.Services;
using MangoAPI.Domain.Constants;

namespace MangoAPI.Presentation.Controllers
{
    /// <summary>
    /// Base controller class. Encapsulates common logic.
    /// </summary>
    public class ApiControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;
        protected readonly IMapper Mapper;
        protected readonly RequestValidationService RequestValidationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiControllerBase"/> class.
        /// </summary>
        /// <param name="mediator">Mediator instance.</param>
        /// <param name="mapper">Automapper instance.</param>
        /// <param name="requestValidationService">Request validator.</param>
        public ApiControllerBase(IMediator mediator, IMapper mapper, RequestValidationService requestValidationService)
        {
            _mediator = mediator;
            Mapper = mapper;
            RequestValidationService = requestValidationService;
        }

        /// <summary>
        /// Common request logic over all controllers.
        /// </summary>
        /// <typeparam name="TResponse">Error data structure.</typeparam>
        /// <param name="request">Generic request type.</param>
        /// <param name="cancellationToken">Cancellation token instance.</param>
        /// <returns>A <see cref="Task{TResult}"/> representing the result of the asynchronous operation.</returns>
        [NonAction]
        protected async Task<IActionResult> RequestAsync<TResponse>(IRequest<Result<TResponse>> request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);

            return response.StatusCode switch
            {
                HttpStatusCode.BadRequest => BadRequest(response.Error),
                HttpStatusCode.Conflict => Conflict(response.Error),
                _ => Ok(response.Response)
            };
        }

        protected IActionResult TooFrequentResponse()
        {
            var requestFactory = new ResponseFactory<TokensResponse>();
            const string message = ResponseMessageCodes.TooFrequentRequest;
            var details = ResponseMessageCodes.ErrorDictionary[message];
            var response = requestFactory.ConflictResponse(message, details);
            return BadRequest(response.Error);
        }
    }
}
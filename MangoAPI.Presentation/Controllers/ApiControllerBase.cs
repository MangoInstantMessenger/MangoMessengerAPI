using System.Net;
using AutoMapper;
using MangoAPI.BusinessLogic.Responses;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace MangoAPI.Presentation.Controllers;

/// <summary>
/// Base controller class. Encapsulates common logic.
/// </summary>
public class ApiControllerBase : ControllerBase
{
    protected readonly IMediator Mediator;
    protected readonly IMapper Mapper;

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiControllerBase"/> class.
    /// </summary>
    /// <param name="mediator">Mediator instance.</param>
    /// <param name="mapper">Automapper instance.</param>
    public ApiControllerBase(IMediator mediator, IMapper mapper)
    {
        Mediator = mediator;
        Mapper = mapper;
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
        CancellationToken cancellationToken) where TResponse : ResponseBase
    {
        var response = await Mediator.Send(request, cancellationToken);

        return response.StatusCode switch
        {
            HttpStatusCode.BadRequest => BadRequest(response.Error),
            HttpStatusCode.Conflict => Conflict(response.Error),
            _ => Ok(response.Response)
        };
    }
}
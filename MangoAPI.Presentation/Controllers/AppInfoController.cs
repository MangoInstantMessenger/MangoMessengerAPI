using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiQueries.AppInfo;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers;

[ApiController]
[Route("api/app-info")]
[Authorize]
public class AppInfoController : ApiControllerBase<AppInfoController>
{
    public AppInfoController(
        IMediator mediator,
        IMapper mapper,
        ICorrelationContext correlationContext,
        ILogger<AppInfoController> logger) 
        : base(mediator, mapper, correlationContext, logger)
    {
    }
    
    [HttpGet]
    [ProducesResponseType(typeof(GetAppInfoResponse), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetAppInfoAsync(CancellationToken cancellationToken)
    {
        var query = new GetAppInfoQuery();

        return await RequestAsync(query, cancellationToken);
    }
}
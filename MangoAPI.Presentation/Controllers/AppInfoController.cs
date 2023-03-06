using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiQueries.AppInfo;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers;

[ApiController]
[Route("api/app-info")]
[Authorize]
public class AppInfoController : ApiControllerBase
{
    public AppInfoController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext) : base(mediator, mapper, correlationContext)
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
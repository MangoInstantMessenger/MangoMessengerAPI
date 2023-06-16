using AutoMapper;
using MangoAPI.Application.Interfaces;
using MangoAPI.BusinessLogic.ApiCommands.ChatGPTMessages;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.Presentation.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
[Authorize]
public class AiController : ApiControllerBase<AiController>, IAiController
{

    public AiController(IMediator mediator, IMapper mapper, ICorrelationContext correlationContext, ILogger<AiController> logger) : base(mediator, mapper, correlationContext, logger)
    {
    }

    [HttpPost("message")]
    [SwaggerOperation(Summary = "Send Request")]
    [SwaggerResponse((int)HttpStatusCode.OK, type: typeof(Conversation))]
    public async Task<IActionResult> Send([FromBody] string text, CancellationToken cancellationToken)
    {
        var userId = CorrelationContext.GetUserId();
        var request = new SendChatGPTMessageCommand(text)
        {
            UserId = userId
        };
        return await RequestAsync(request, cancellationToken);
    }
}
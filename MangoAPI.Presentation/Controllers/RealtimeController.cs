using MangoAPI.BusinessLogic.HubConfig;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Controllers;

[ApiController]
[Route("api/realtime")]
[Authorize]
public class RealtimeController : ControllerBase
{
    private readonly IHubContext<ChatHub, IHubClient> hubContext;

    public RealtimeController(IHubContext<ChatHub, IHubClient> hubContext)
    {
        this.hubContext = hubContext;
    }

    [HttpPost("send-new-message-notification")]
    public async Task<IActionResult> SendNewMessageNotificationAsync([FromBody] Message request)
    {
        await hubContext.Clients.Group(request.ChatId.ToString()).BroadcastMessageAsync(request);

        return Ok(ResponseBase.SuccessResponse);
    }
}
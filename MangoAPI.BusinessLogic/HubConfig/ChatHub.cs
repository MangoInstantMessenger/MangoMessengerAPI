using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MangoAPI.BusinessLogic.HubConfig;

public class ChatHub : Hub<IHubClient>
{
    public Task SubscribeToGroup(string groupId)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, groupId);
    }
}

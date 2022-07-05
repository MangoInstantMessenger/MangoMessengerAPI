using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MangoAPI.BusinessLogic.HubConfig;

public class ChatHub : Hub<IHubClient>
{
    public Task JoinGroup(string groupName)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
    }
}

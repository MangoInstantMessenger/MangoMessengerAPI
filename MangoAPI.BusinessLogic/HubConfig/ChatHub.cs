using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.HubConfig;

public class ChatHub : Hub<IHubClient>
{
    public Task JoinGroup(string groupName)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
    }
}
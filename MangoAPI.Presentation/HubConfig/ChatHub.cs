using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.HubConfig
{
    public class ChatHub : Hub
    {
        public Task JoinGroup(string groupName)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, groupName);
        }
    }
}

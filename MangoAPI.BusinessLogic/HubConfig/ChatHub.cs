using MangoAPI.BusinessLogic.Models;
using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.HubConfig
{
    public class ChatHub : Hub<IHubClient>
    {
        public Task JoinChatGroup(string chatId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, chatId);
        }

        public Task ConnectUser(string userId)
        {
            return Groups.AddToGroupAsync(Context.ConnectionId, userId);
        }

        public Task NotifyChatGroup(string chatId, Message message)
        {
            return Clients.Group(chatId).BroadcastMessage(message);
        }
    }
}
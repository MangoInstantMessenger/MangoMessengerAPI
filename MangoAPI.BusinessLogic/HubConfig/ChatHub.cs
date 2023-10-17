using MangoAPI.BusinessLogic.Notifications;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using System;

namespace MangoAPI.BusinessLogic.HubConfig;

public class ChatHub : Hub<IHubClient>
{
    public Task SubscribeToGroup(string groupId)
    {
        return Groups.AddToGroupAsync(Context.ConnectionId, groupId);
    }

    public Task ShowTyping(Guid userId, Guid groupId, string displayName)
    {
        var notification = new TypingEventNotification(userId, groupId, displayName);

        return Clients.Group(groupId.ToString()).PrivateChatSentTypingEventAsync(notification);
    }
}

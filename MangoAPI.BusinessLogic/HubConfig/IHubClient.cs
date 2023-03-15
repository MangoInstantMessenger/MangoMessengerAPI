using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;
using System;

namespace MangoAPI.BusinessLogic.HubConfig;

public interface IHubClient
{
    /// <summary>
    /// Notifies chat subscribers on the message sent via SignalR.
    /// </summary>
    Task BroadcastMessageAsync(Message message);

    /// <summary>
    /// Pushes new created private chat to the receiver's chats list via SignalR.
    /// </summary>
    Task PrivateChatCreatedAsync(Chat chat);
    
    /// <summary>
    /// Removes deleted private chat from the receiver's chats list via SignalR.
    /// </summary>
    Task PrivateChatDeletedAsync(Guid chatId);

    /// <summary>
    /// Notifies chat subscribers on the message delete via SignalR.
    /// </summary>
    Task NotifyOnMessageDeleteAsync(MessageDeleteNotification notification);

    /// <summary>
    /// Notifies chat subscribers on the message edit via SignalR.
    /// </summary>
    Task NotifyOnMessageEditAsync(MessageEditNotification notification);
}

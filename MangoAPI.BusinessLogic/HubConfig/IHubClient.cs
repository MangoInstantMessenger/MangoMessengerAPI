using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Notifications;

namespace MangoAPI.BusinessLogic.HubConfig;

public interface IHubClient
{
    /// <summary>
    /// Notifies chat subscribers on the message sent via SignalR.
    /// </summary>
    Task MessageSentAsync(SendMessageNotification notification);

    /// <summary>
    /// Pushes new created private chat to the receiver's chats list via SignalR.
    /// </summary>
    Task PrivateChatCreatedAsync(PrivateChatCreatedNotification notification);

    /// <summary>
    /// Removes deleted private chat from the receiver's chats list via SignalR.
    /// </summary>
    Task PrivateChatDeletedAsync(PrivateChatDeletedNotification notification);

    /// <summary>
    /// Notifies chat subscribers on the message delete via SignalR.
    /// </summary>
    Task MessageDeletedAsync(DeleteMessageNotification notification);

    /// <summary>
    /// Notifies chat subscribers on the typing event via SignalR.
    /// </summary>
    Task PrivateChatSentTypingEventAsync(TypingEventNotification notification);
}
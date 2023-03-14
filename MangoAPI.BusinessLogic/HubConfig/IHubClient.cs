using System.Threading.Tasks;
using MangoAPI.BusinessLogic.Models;

namespace MangoAPI.BusinessLogic.HubConfig;

public interface IHubClient
{
    /// <summary>
    /// Notifies chat subscribers on the message sent via SignalR.
    /// </summary>
    Task BroadcastMessageAsync(Message message);

    /// <summary>
    /// Updates client list of chats via SignalR.
    /// </summary>
    Task PrivateChatCreatedAsync(Chat chat);

    /// <summary>
    /// Notifies chat subscribers on the message delete via SignalR.
    /// </summary>
    Task NotifyOnMessageDeleteAsync(MessageDeleteNotification notification);

    /// <summary>
    /// Notifies chat subscribers on the message edit via SignalR.
    /// </summary>
    Task NotifyOnMessageEditAsync(MessageEditNotification notification);
}

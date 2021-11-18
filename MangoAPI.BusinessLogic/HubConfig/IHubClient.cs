using System;
using MangoAPI.BusinessLogic.Models;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.HubConfig
{
    public interface IHubClient
    {
        /// <summary>
        /// Notifies chat subscribers on the message sent via SignalR.
        /// </summary>
        Task BroadcastMessage(Message message);

        /// <summary>
        /// Updates client list of chats via SignalR.
        /// </summary>
        Task UpdateUserChats(Chat chat);

        /// <summary>
        /// Notifies chat subscribers on the message delete via SignalR.
        /// </summary>
        Task NotifyOnMessageDelete(Guid messageId);

        /// <summary>
        /// Notifies chat subscribers on the message edit via SignalR.
        /// </summary>
        Task NotifyOnMessageEdit(MessageEditNotification notification);
    }
}
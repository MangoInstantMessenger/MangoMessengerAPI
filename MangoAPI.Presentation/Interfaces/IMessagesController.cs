using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Messages;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IMessagesController
    {
        Task<IActionResult> GetChatMessages(Guid chatId, CancellationToken cancellationToken);

        Task<IActionResult> SearchChatMessages(Guid chatId, string messageText, CancellationToken cancellationToken);

        Task<IActionResult> SendMessage(SendMessageRequest request, CancellationToken cancellationToken);

        Task<IActionResult> EditMessage(EditMessageRequest request, CancellationToken cancellationToken);

        Task<IActionResult> DeleteMessage(Guid messageId, CancellationToken cancellationToken);
    }
}
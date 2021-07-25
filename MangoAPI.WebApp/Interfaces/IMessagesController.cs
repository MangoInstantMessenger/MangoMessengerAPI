using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IMessagesController
    {
        Task<IActionResult> GetChatMessages(string chatId, CancellationToken cancellationToken);
        Task<IActionResult> SendMessage(SendMessageCommand command, CancellationToken cancellationToken);
        Task<IActionResult> EditMessage(EditMessageCommand command, CancellationToken cancellationToken);
        Task<IActionResult> DeleteMessage(string messageId, CancellationToken cancellationToken);
    }
}
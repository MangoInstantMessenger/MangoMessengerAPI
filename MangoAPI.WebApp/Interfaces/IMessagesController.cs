using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.CommandModels.Messages;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IMessagesController
    {
        Task<IActionResult> GetChatMessages(string chatId, CancellationToken cancellationToken);
        Task<IActionResult> SendMessage(SendMessageCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> EditMessage(EditMessageCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> DeleteMessage(string messageId, CancellationToken cancellationToken);
    }
}
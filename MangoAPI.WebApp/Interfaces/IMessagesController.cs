using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.RequestModels.Messages;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IMessagesController
    {
        Task<IActionResult> GetChatMessages(string chatId, CancellationToken cancellationToken);
        Task<IActionResult> SendMessage(SendMessageRequest request, CancellationToken cancellationToken);
        Task<IActionResult> EditMessage(EditMessageRequest request, CancellationToken cancellationToken);
        Task<IActionResult> DeleteMessage(DeleteMessageRequest request, CancellationToken cancellationToken);
    }
}
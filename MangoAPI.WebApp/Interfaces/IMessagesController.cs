using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Messages;
using MangoAPI.DTO.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IMessagesController
    {
        Task<IActionResult> GetChatMessages(GetChatMessagesQuery query, CancellationToken cancellationToken);
        Task<IActionResult> SendMessage(SendChatMessageCommand command, CancellationToken cancellationToken);
        Task<IActionResult> EditMessage(EditChatMessageCommand command, CancellationToken cancellationToken);
        Task<IActionResult> DeleteMessage(DeleteChatMessageCommand command, CancellationToken cancellationToken);
    }
}
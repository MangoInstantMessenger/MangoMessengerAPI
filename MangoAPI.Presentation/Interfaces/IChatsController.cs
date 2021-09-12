using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);

        Task<IActionResult> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken);

        Task<IActionResult> CreateChatAsync(CreateChatRequest request, CancellationToken cancellationToken);

        Task<IActionResult> SearchById(Guid chatId, CancellationToken cancellationToken);
        
        Task<IActionResult> SearchAsync(string displayName, CancellationToken cancellationToken);
    }
}

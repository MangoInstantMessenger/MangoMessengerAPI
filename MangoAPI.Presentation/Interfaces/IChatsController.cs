using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);
        Task<IActionResult> CreateChatAsync(CreateGroupRequest request, CancellationToken cancellationToken);
        Task<IActionResult> CreateChatAsync(string userId, CancellationToken cancellationToken);
        Task<IActionResult> SearchAsync(SearchChatsRequest request, CancellationToken cancellationToken);
    }
}
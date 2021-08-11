using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);
        Task<IActionResult> CreateChat(CreateGroupRequest request, CancellationToken cancellationToken);
        Task<IActionResult> CreateDirectChat(CreateDirectChatRequest request, CancellationToken cancellationToken);
        Task<IActionResult> JoinChat(JoinChatRequest request, CancellationToken cancellationToken);
        Task<IActionResult> SearchChat(string displayName, CancellationToken cancellationToken);
    }
}
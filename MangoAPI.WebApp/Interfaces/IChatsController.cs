using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.RequestModels.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);
        Task<IActionResult> CreateChat(CreateGroupRequest request, CancellationToken cancellationToken);
        Task<IActionResult> CreateDirectChat(CreateDirectChatRequest request, CancellationToken cancellationToken);
        Task<IActionResult> JoinChat(JoinChatRequest request, CancellationToken cancellationToken);
    }
}
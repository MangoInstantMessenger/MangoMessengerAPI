using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.CommandModels.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);
        Task<IActionResult> CreateChat(CreateGroupCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> CreateDirectChat(CreateDirectChatCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> JoinChat(JoinChatCommandModel commandModel, CancellationToken cancellationToken);
    }
}
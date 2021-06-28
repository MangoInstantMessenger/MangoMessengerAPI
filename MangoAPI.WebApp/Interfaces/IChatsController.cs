using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Chats;
using MangoAPI.DTO.Queries.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IChatsController
    {
        Task<IActionResult> GetChats(GetChatsQuery query, CancellationToken cancellationToken);
        Task<IActionResult> CreateChat(CreateChatCommand command, CancellationToken cancellationToken);
    }
}
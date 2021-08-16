using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUserChatsController
    {
        Task<IActionResult> JoinChatAsync(JoinChatRequest request, CancellationToken cancellationToken);
    }
}
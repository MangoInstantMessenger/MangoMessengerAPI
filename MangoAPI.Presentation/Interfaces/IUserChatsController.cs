using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Chats;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUserChatsController
    {
        Task<IActionResult> JoinChatAsync(JoinChatRequest request, CancellationToken cancellationToken);
    }
}
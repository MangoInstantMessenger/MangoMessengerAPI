using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUserChatsController
    {
        Task<IActionResult> JoinChatAsync(string chatId, CancellationToken cancellationToken);
    }
}
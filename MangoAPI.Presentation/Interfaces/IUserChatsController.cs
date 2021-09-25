using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserChats;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUserChatsController
    {
        Task<IActionResult> JoinChatAsync(Guid chatId, CancellationToken cancellationToken);
        Task<IActionResult> LeaveGroup(Guid chatId, CancellationToken cancellationToken);
        Task<IActionResult> ArchiveChat(Guid chatId, CancellationToken cancellationToken);
    }
}
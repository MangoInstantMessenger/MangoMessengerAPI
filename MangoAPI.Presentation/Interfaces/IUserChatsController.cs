namespace MangoAPI.Presentation.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;

    public interface IUserChatsController
    {
        Task<IActionResult> JoinChatAsync(string chatId, CancellationToken cancellationToken);
    }
}

namespace MangoAPI.Presentation.Interfaces
{
    using System.Threading;
    using System.Threading.Tasks;
    using MangoAPI.BusinessLogic.ApiCommands.Chats;
    using Microsoft.AspNetCore.Mvc;

    public interface IChatsController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);

        Task<IActionResult> CreateChatAsync(CreateGroupRequest request, CancellationToken cancellationToken);

        Task<IActionResult> CreateChatAsync(string userId, CancellationToken cancellationToken);

        Task<IActionResult> SearchAsync(string displayName, CancellationToken cancellationToken);
    }
}

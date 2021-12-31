using System;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ICommunitiesController
    {
        Task<IActionResult> GetChatsAsync(CancellationToken cancellationToken);

        Task<IActionResult> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken);

        Task<IActionResult> CreateChatAsync(CreateChatRequest request, CancellationToken cancellationToken);

        Task<IActionResult> SearchAsync(string displayName, CancellationToken cancellationToken);

        Task<IActionResult> UpdateChannelPictureAsync(Guid chatId, IFormFile newGroupPicture,
            CancellationToken cancellationToken);
    }
}
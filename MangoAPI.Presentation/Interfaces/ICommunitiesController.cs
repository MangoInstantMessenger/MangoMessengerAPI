using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface ICommunitiesController
{
    Task<IActionResult> GetChatsAsync(CancellationToken cancellationToken);

    Task<IActionResult> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken);

    Task<IActionResult> CreateChatAsync(Guid userId, CancellationToken cancellationToken);

    Task<IActionResult> SearchAsync(string displayName, CancellationToken cancellationToken);

    Task<IActionResult> UpdateChannelPictureAsync(
        Guid chatId,
        IFormFile newGroupPicture,
        CancellationToken cancellationToken);
}

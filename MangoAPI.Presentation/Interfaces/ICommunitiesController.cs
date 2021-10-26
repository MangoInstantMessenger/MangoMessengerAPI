using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Communities;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ICommunitiesController
    {
        Task<IActionResult> GetChats(CancellationToken cancellationToken);

        Task<IActionResult> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken);

        Task<IActionResult> CreateChatAsync(CreateChatRequest request, CancellationToken cancellationToken);

        Task<IActionResult> GetCommunityById(Guid id, CancellationToken cancellationToken);

        Task<IActionResult> SearchAsync(string displayName, CancellationToken cancellationToken);

        Task<IActionResult> UpdateChannelPicture(UpdateChanelPictureRequest request, CancellationToken cancellationToken);
    }
}

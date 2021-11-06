using MangoAPI.BusinessLogic.ApiCommands.Communities;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ICommunitiesController
    {
        Task<IActionResult> GetChatsAsync(CancellationToken cancellationToken);

        Task<IActionResult> CreateChannelAsync(CreateChannelRequest request, CancellationToken cancellationToken);

        Task<IActionResult> CreateChatAsync(CreateChatRequest request, CancellationToken cancellationToken);

        Task<IActionResult> SearchAsync(string displayName, CancellationToken cancellationToken);

        Task<IActionResult> UpdateChannelPictureAsync(UpdateChanelPictureRequest request, CancellationToken cancellationToken);
    }
}
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUsersController
    {
        Task<IActionResult> GetUserById(string userId, CancellationToken cancellationToken);
        Task<IActionResult> SearchUsersByDisplayName(string displayName, CancellationToken cancellationToken);
        Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken);
    }
}
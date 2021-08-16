using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ISessionController
    {
        Task<IActionResult> LoginAsync(LoginRequest request, CancellationToken cancellationToken);
        Task<IActionResult> RefreshSession(string id, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAsync(string id, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAllAsync(LogoutAllRequest request, CancellationToken cancellationToken);
    }
}
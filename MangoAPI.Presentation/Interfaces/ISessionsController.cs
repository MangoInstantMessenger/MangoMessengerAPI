using System;
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ISessionsController
    {
        Task<IActionResult> LoginAsync(LoginRequest request, CancellationToken cancellationToken);

        Task<IActionResult> RefreshSession(Guid refreshToken, CancellationToken cancellationToken);

        Task<IActionResult> LogoutAsync(Guid refreshToken, CancellationToken cancellationToken);

        Task<IActionResult> LogoutAllAsync(CancellationToken cancellationToken);
    }
}
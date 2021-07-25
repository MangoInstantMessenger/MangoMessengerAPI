
using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.CommandModels.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IAuthController
    {
        Task<IActionResult> LoginAsync(LoginCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> RegisterAsync(RegisterCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> VerifyPhoneCodeAsync(VerifyPhoneCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> RefreshTokenAsync(RefreshTokenCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAsync(LogoutCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAllDevicesAsync(LogoutAllCommandModel commandModel, CancellationToken cancellationToken);
        Task<IActionResult> VerifyEmailAsync(string email, string userId, CancellationToken cancellationToken);
    }
}
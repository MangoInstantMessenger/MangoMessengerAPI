using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IAuthController
    {
        Task<IActionResult> LoginAsync(LoginCommand command, CancellationToken cancellationToken);
        Task<IActionResult> RegisterAsync(RegisterCommand command, CancellationToken cancellationToken);
        Task<IActionResult> VerifyPhoneCodeAsync(VerifyPhoneCommand command, CancellationToken cancellationToken);
        Task<IActionResult> RefreshTokenAsync(RefreshTokenCommand command, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAsync(LogoutCommand command, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAllDevicesAsync(LogoutAllCommand command, CancellationToken cancellationToken);
        Task<IActionResult> VerifyEmailAsync(string email, string userId, CancellationToken cancellationToken);
    }
}

using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IAuthController
    {
        Task<IActionResult> LoginAsync(LoginRequest request, CancellationToken cancellationToken);
        Task<IActionResult> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken);
        Task<IActionResult> VerifyPhoneCodeAsync(VerifyPhoneRequest request, CancellationToken cancellationToken);
        Task<IActionResult> RefreshTokenAsync(RefreshTokenRequest request, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAsync(LogoutRequest request, CancellationToken cancellationToken);
        Task<IActionResult> LogoutAllDevicesAsync(LogoutAllRequest request, CancellationToken cancellationToken);
        Task<IActionResult> VerifyEmailAsync(string email, string userId, CancellationToken cancellationToken);
    }
}
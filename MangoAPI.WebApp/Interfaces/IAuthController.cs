using System.Threading.Tasks;
using MangoAPI.DTO.Commands.Auth;
using MangoAPI.DTO.Common;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IAuthController
    {
        Task<IActionResult> LoginAsync(LoginCommand command);
        Task<IActionResult> RegisterAsync(RegisterCommand command);
        Task<IActionResult> ConfirmRegisterAsync(ConfirmRegisterCommand command);
        Task<IActionResult> RefreshTokenAsync(RefreshTokenCommand command);
        RequestMetadata RequestMetadata { get; }
        // Task<IActionResult> RevokeTokenAsync();
        // Task<IActionResult> LogoutAsync();
    }
}
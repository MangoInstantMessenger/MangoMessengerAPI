using System.Threading.Tasks;
using MangoAPI.Application.Common;
using MangoAPI.DTO.Commands.Auth;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IAuthController
    {
        Task<IActionResult> LoginAsync(LoginCommand command);
        Task<IActionResult> RegisterAsync(RegisterCommand command);
        Task<IActionResult> ConfirmRegisterAsync(ConfirmRegisterCommand command);
        Task<IActionResult> RefreshTokenAsync();
        // Task<IActionResult> RevokeTokenAsync();
        // Task<IActionResult> LogoutAsync();
    }
}
using System;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUsersController
    {
        Task<IActionResult> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken);

        Task<IActionResult> EmailConfirmationAsync(VerifyEmailRequest request, CancellationToken cancellationToken);

        Task<IActionResult> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken);

        Task<IActionResult> GetUserById(Guid userId, CancellationToken cancellationToken);

        Task<IActionResult> UpdateUserAccountInfoAsync(UpdateUserAccountInfoRequest request,
            CancellationToken cancellationToken);

        Task<IActionResult> UpdateUserSocialInformationAsync(UpdateUserSocialInformationRequest request,
            CancellationToken cancellationToken);

        Task<IActionResult> UpdateProfilePictureAsync(IFormFile pictureFile, CancellationToken cancellationToken);
    }
}
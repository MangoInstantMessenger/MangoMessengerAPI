namespace MangoAPI.Presentation.Interfaces
{
    using BusinessLogic.ApiCommands.Users;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading;
    using System.Threading.Tasks;

    public interface IUsersController
    {
        Task<IActionResult> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken);

        Task<IActionResult> EmailConfirmationAsync(VerifyEmailRequest request, CancellationToken cancellationToken);

        Task<IActionResult> PhoneConfirmationAsync(int phoneCode, CancellationToken cancellationToken);

        Task<IActionResult> ChangePassword(ChangePasswordRequest request, CancellationToken cancellationToken);

        Task<IActionResult> GetUserById(string userId, CancellationToken cancellationToken);

        Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken);

        Task<IActionResult> UpdateUserInformationAsync(UpdateUserInformationRequest request, CancellationToken cancellationToken);
    }
}
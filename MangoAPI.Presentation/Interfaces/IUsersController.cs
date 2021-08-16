using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.Users;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUsersController
    {
        Task<IActionResult> RegisterAsync(RegisterRequest request, CancellationToken cancellationToken);
        Task<IActionResult> EmailConfirmationAsync(VerifyEmailRequest request, CancellationToken cancellationToken);
        Task<IActionResult> PhoneConfirmationAsync(VerifyPhoneRequest request, CancellationToken cancellationToken);
        Task<IActionResult> GetUserById(string userId, CancellationToken cancellationToken);
        Task<IActionResult> SearchesAsync(UserSearchCommand request, CancellationToken cancellationToken);
        Task<IActionResult> GetCurrentUser(CancellationToken cancellationToken);

        Task<IActionResult> UpdateUserInformationAsync(UpdateUserInformationRequest request,
            CancellationToken cancellationToken);
    }
}
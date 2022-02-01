using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces;

public interface IPasswordRestoreRequestsController
{
    public Task<IActionResult> RestorePasswordRequestAsync(string email, CancellationToken cancellationToken);

    public Task<IActionResult> RestorePasswordAsync(PasswordRestoreRequest request,
        CancellationToken cancellationToken);
}
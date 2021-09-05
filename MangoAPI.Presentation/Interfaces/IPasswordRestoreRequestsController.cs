using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IPasswordRestoreRequestsController
    {
        public Task<IActionResult> RestorePasswordAsync(string emailOrPhone, CancellationToken cancellationToken);
    }
}
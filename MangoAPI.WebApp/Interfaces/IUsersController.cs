using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IUsersController
    {
        Task<IActionResult> FindUser(string userId, CancellationToken cancellationToken);
    }
}
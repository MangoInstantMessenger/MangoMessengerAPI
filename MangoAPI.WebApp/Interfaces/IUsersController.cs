using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.Queries.Users;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IUsersController
    {
        Task<IActionResult> FindUser(FindUserQuery query, CancellationToken cancellationToken);
    }
}
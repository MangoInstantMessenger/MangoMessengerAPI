using System.Threading;
using System.Threading.Tasks;
using MangoAPI.DTO.ApiCommands.UserInformation;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.WebApp.Interfaces
{
    public interface IUserInformationController
    {
        public Task<IActionResult> UpdateUserInformation(UpdateUserInformationRequest request, CancellationToken cancellationToken);
    }
}
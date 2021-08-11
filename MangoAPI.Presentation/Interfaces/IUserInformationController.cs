using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.UserInformation;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface IUserInformationController
    {
        public Task<IActionResult> UpdateUserInformation(UpdateUserInformationRequest request, CancellationToken cancellationToken);
    }
}
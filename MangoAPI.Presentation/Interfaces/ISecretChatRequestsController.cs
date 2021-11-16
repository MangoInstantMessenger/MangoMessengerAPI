using System.Threading;
using System.Threading.Tasks;
using MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ISecretChatRequestsController
    {
        public Task<IActionResult> GetSecretChatRequests(CancellationToken cancellationToken);

        public Task<IActionResult> CreateSecretChatRequest(CreateSecretChatRequest request,
            CancellationToken cancellationToken);

        public Task<IActionResult> ConfirmOrDeclineSecretChatRequest(ConfirmOrDeclineSecretChatRequest request,
            CancellationToken cancellationToken);
    }
}
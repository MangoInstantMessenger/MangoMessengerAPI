using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ISecretChatRequestsController
    {
        public Task<IActionResult> GetSecretChatRequests(CancellationToken cancellationToken);
        public Task<IActionResult> CreateSecretChatRequest(Guid requestedUserId, CancellationToken cancellationToken);

        public Task<IActionResult> ConfirmOrDeclineSecretChatRequest(Guid requestId, bool confirmed,
            CancellationToken cancellationToken);
    }
}
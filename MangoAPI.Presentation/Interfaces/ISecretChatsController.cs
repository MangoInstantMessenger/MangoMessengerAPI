using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MangoAPI.Presentation.Interfaces
{
    public interface ISecretChatsController
    {
        public Task<IActionResult> GetSecretChatRequests();
        public Task<IActionResult> CreateSecretChatRequest(Guid requestedUserId);
        public Task<IActionResult> ConfirmOrDeclineSecretChatRequest(Guid requestId, bool confirmed);
    }
}
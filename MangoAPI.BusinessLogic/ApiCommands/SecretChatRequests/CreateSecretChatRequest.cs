using System;

namespace MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests
{
    public record CreateSecretChatRequest
    {
        public Guid RequestedUserId { get; init; }
        public string PublicKey { get; init; }
    }
}
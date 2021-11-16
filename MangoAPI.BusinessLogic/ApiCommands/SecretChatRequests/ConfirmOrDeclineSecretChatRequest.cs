using System;

namespace MangoAPI.BusinessLogic.ApiCommands.SecretChatRequests
{
    public record ConfirmOrDeclineSecretChatRequest
    {
        public Guid RequestId { get; init; }
        public bool Confirmed { get; init; }
    }
}
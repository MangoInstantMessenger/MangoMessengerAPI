using System;

namespace MangoAPI.BusinessLogic.Models
{
    public record KeyExchangeRequest
    {
        public Guid RequestId { get; init; }
        public Guid SenderId { get; init; }
        public string SenderPublicKey { get; init; }
    }
}
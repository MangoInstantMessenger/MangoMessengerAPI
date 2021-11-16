using System;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange
{
    public record ConfirmOrDeclineKeyExchangeRequest
    {
        public Guid RequestId { get; init; }
        public bool Confirmed { get; init; }
    }
}
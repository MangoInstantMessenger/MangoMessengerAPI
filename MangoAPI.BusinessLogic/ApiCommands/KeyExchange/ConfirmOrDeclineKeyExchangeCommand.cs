using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange
{
    public record ConfirmOrDeclineKeyExchangeCommand : IRequest<Result<ResponseBase>>
    {
        public Guid UserId { get; init; }
        public Guid RequestId { get; init; }
        public bool Confirmed { get; init; }
    }
}
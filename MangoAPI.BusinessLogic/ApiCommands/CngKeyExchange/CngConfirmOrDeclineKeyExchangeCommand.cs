using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngConfirmOrDeclineKeyExchangeCommand : IRequest<Result<ResponseBase>>
{
    public Guid UserId { get; init; }
    public Guid RequestId { get; init; }
    public bool Confirmed { get; init; }
    public string PublicKey { get; init; }
}
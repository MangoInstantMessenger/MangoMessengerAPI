using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record OpenSslDeclineKeyExchangeCommand : IRequest<Result<ResponseBase>>
{
    public Guid RequestId { get; init; }
    public Guid UserId { get; init; }
}
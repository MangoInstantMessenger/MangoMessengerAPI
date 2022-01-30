using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public record CreateKeyExchangeRequestCommand : IRequest<Result<CreateKeyExchangeResponse>>
{
    public Guid UserId { get; init; }
    public Guid RequestedUserId { get; init; }
    public string PublicKey { get; init; }
}
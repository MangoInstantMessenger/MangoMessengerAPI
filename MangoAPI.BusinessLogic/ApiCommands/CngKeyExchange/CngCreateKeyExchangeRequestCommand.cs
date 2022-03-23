using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngCreateKeyExchangeRequestCommand : IRequest<Result<CngCreateKeyExchangeResponse>>
{
    public Guid UserId { get; init; }
    public Guid RequestedUserId { get; init; }
    public string PublicKey { get; init; }
}
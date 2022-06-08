using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngCreateKeyExchangeRequestCommand(Guid UserId, Guid RequestedUserId, string PublicKey)
    : IRequest<Result<CngCreateKeyExchangeResponse>>;

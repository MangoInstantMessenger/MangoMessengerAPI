using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public record DeclineKeyExchangeCommand(Guid RequestId, Guid UserId)
    : IRequest<Result<ResponseBase>>;

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngConfirmOrDeclineKeyExchangeCommand(Guid UserId, Guid RequestId, bool Confirmed, string PublicKey)
    : IRequest<Result<ResponseBase>>;

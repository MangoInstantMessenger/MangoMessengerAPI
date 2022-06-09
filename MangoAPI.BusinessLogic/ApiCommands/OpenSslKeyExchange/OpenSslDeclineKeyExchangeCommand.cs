using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslDeclineKeyExchangeCommand(Guid RequestId, Guid UserId) : IRequest<Result<ResponseBase>>;
using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslConfirmKeyExchangeCommand(Guid RequestId, Guid UserId, IFormFile ReceiverPublicKey) 
    : IRequest<Result<ResponseBase>>;
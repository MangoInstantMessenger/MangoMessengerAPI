using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngConfirmKeyExchangeCommand(
    Guid UserId,
    Guid RequestId,
    IFormFile ReceiverPublicKey) : IRequest<Result<ResponseBase>>;
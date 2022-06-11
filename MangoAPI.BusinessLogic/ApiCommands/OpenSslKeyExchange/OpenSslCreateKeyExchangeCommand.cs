using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslCreateKeyExchangeCommand(
    Guid ReceiverId,
    Guid SenderId,
    IFormFile SenderPublicKey) : IRequest<Result<OpenSslCreateKeyExchangeResponse>>;
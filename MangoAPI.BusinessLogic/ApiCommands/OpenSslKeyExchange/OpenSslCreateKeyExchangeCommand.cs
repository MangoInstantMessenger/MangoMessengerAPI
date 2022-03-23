using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslCreateKeyExchangeCommand : IRequest<Result<OpenSslCreateKeyExchangeResponse>>
{
    public Guid SenderId { get; init; }
    public Guid ReceiverId { get; init; }
    public IFormFile SenderPublicKey { get; init; }
}
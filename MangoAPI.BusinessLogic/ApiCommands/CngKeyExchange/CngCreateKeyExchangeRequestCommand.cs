using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.CngKeyExchange;

public record CngCreateKeyExchangeRequestCommand(
    Guid SenderId,
    Guid ReceiverId,
    IFormFile SenderPublicKey) : IRequest<Result<CngCreateKeyExchangeResponse>>;
using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public record CreateKeyExchangeCommand(
    Guid ReceiverId,
    Guid SenderId,
    IFormFile SenderPublicKey) : IRequest<Result<CreateKeyExchangeResponse>>;
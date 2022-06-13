using System;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Enums;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public record CreateKeyExchangeCommand(
    Guid ReceiverId,
    Guid SenderId,
    IFormFile SenderPublicKey, 
    KeyExchangeType KeyExchangeType) : IRequest<Result<CreateKeyExchangeResponse>>;
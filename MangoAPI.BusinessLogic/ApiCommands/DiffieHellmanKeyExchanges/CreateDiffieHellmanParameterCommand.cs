using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.DiffieHellmanKeyExchanges;

public record CreateDiffieHellmanParameterCommand(IFormFile DiffieHellmanParameter, Guid UserId)
    : IRequest<Result<CreateDiffieHellmanParameterResponse>>;

using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.OpenSslKeyExchange;

public record OpenSslCreateDiffieHellmanParameterCommand(IFormFile DiffieHellmanParameter, Guid UserId) 
    : IRequest<Result<OpenSslCreateDiffieHellmanParameterResponse>>;
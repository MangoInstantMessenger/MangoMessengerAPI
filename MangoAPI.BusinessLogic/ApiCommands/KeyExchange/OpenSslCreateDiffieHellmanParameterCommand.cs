using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class OpenSslCreateDiffieHellmanParameterCommand : IRequest<Result<OpenSslCreateDiffieHellmanParameterResponse>>
{
    public IFormFile DiffieHellmanParameter { get; init; }
    public Guid UserId { get; init; }
}
using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.KeyExchange;

public class CreateDiffieHellmanParameterCommand : IRequest<Result<CreateDiffieHellmanParameterResponse>>
{
    public IFormFile DiffieHellmanParameter { get; init; }
    public Guid UserId { get; init; }
}
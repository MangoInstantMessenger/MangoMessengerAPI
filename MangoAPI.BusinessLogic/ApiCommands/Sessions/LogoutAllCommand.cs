using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LogoutAllCommand : IRequest<Result<ResponseBase>>
{
    public Guid UserId { get; init; }
}
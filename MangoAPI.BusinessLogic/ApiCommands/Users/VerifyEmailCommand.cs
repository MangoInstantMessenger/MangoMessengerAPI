using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record VerifyEmailCommand : IRequest<Result<ResponseBase>>
{
    public string Email { get; init; }
    public Guid EmailCode { get; init; }
}
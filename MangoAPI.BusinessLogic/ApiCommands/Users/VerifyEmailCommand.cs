using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record VerifyEmailCommand : IRequest<Result<ResponseBase>>
{
    public VerifyEmailCommand()
    {
        
    }

    public VerifyEmailCommand(string email, Guid emailCode)
    {
        Email = email;
        EmailCode = emailCode;
    }
    public string Email { get; init; }
    public Guid EmailCode { get; init; }
}
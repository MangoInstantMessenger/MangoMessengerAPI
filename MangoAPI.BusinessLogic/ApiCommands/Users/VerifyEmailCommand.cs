using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record VerifyEmailCommand(
        string Email,
        Guid EmailCode)
    : IRequest<Result<ResponseBase>>;

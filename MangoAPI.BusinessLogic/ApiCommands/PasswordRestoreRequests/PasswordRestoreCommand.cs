using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public record PasswordRestoreCommand(Guid RequestId, string NewPassword, string RepeatPassword)
    : IRequest<Result<ResponseBase>>;

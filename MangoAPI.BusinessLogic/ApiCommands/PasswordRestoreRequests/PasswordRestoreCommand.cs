using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.PasswordRestoreRequests;

public record PasswordRestoreCommand(Guid RequestId, string NewPassword, string RepeatPassword) 
    : IRequest<Result<ResponseBase>>;
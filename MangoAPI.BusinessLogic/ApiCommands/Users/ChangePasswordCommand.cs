using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record ChangePasswordCommand(Guid UserId, string CurrentPassword, string NewPassword, string RepeatNewPassword) 
    : IRequest<Result<ResponseBase>>;
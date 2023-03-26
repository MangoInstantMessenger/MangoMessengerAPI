using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LogoutCommand(Guid UserId, Guid RefreshToken)
    : IRequest<Result<ResponseBase>>;
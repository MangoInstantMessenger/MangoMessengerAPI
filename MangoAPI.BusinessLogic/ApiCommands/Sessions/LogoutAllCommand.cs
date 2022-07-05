using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Sessions;

public record LogoutAllCommand(Guid UserId)
    : IRequest<Result<ResponseBase>>;

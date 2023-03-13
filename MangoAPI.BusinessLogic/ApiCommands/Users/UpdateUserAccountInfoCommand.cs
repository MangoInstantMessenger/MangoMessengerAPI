using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Users;

public record UpdateUserAccountInfoCommand(
        Guid UserId,
        string Username,
        string DisplayName,
        string Website,
        string Bio,
        string Address,
        DateTime? Birthday)
    : IRequest<Result<ResponseBase>>;

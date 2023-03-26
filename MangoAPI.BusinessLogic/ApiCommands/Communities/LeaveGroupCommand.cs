using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities;

public record LeaveGroupCommand(Guid UserId, Guid ChatId)
    : IRequest<Result<LeaveGroupResponse>>;
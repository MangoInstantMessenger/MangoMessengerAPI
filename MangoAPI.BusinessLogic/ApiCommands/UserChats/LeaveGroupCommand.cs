using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats;

public record LeaveGroupCommand(Guid UserId, Guid ChatId) : IRequest<Result<LeaveGroupResponse>>;
using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record LeaveGroupCommand : IRequest<Result<LeaveGroupResponse>>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
    }
}
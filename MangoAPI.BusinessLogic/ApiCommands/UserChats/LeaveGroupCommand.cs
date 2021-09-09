using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record LeaveGroupCommand : IRequest<LeaveGroupResponse>
    {
        public Guid UserId { get; init; }
        public Guid ChatId { get; init; }
    }
}
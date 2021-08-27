using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record LeaveGroupCommand : IRequest<LeaveGroupResponse>
    {
        public string UserId { get; set; }
        public string ChatId { get; set; }
    }
}
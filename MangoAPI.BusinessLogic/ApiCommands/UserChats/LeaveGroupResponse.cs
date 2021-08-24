using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record LeaveGroupResponse : ResponseBase<LeaveGroupResponse>
    {
        public string ChatId { get; init; }

        public static LeaveGroupResponse FromSuccess(ChatEntity chat)
        {
            return new()
            {
                Success = true,
                Message = ResponseMessageCodes.Success,
                ChatId = chat.Id,
            };
        }
    }
}
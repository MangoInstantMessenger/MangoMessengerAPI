using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetChatByIdResponse : ResponseBase<GetChatByIdResponse>
    {
        public Chat Chat { get; init; }

        public static GetChatByIdResponse FromSuccess(Chat chat) => new()
        {
            Chat = chat,
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}
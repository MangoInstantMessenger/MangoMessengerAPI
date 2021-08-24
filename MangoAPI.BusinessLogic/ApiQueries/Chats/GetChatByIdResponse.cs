using System.Linq;
using System.Reflection;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetChatByIdResponse : ChatResponseBase<GetChatByIdResponse>
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
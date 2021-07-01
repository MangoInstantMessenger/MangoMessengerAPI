using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public class GetChatByIdResponse : ResponseBase
    {
        public Chat Chat { get; set; }

        public static GetChatByIdResponse SuspiciousAction => new()
        {
            Message = ResponseMessageCodes.SuspiciousAction,
            Success = false
        };

        public static GetChatByIdResponse InvalidOrEmptyRefreshToken => new()
        {
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken,
            Success = false
        };

        public static GetChatByIdResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static GetChatByIdResponse PermissionDenied => new()
        {
            Message = ResponseMessageCodes.PermissionDenied,
            Success = false
        };

        public static GetChatByIdResponse ChatNotFound => new()
        {
            Message = ResponseMessageCodes.ChatNotFound,
            Success = false
        };

        public static GetChatByIdResponse FromSuccess(ChatEntity chat) => new()
        {
            Message = ResponseMessageCodes.Success,

            Chat = new Chat
            {
                Title = chat.Title,
                Image = chat.Image,
                Messages = chat.Messages.Select(x => new Message
                {
                    MessageText = x.Content,
                    EditedAt = x.Updated,
                    SentAt = x.Created,
                    UserDisplayName = x.User.DisplayName
                }).ToList(),
            },

            Success = true
        };
    }
}
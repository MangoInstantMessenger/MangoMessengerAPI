using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public class GetChatsResponse : ResponseBase
    {
        public List<UserChat> Chats { get; set; }

        public static GetChatsResponse Suspicious => new()
        {
            Message = ResponseMessageCodes.SuspiciousAction,
            Success = false
        };

        public static GetChatsResponse InvalidRefreshToken => new()
        {
            Message = ResponseMessageCodes.InvalidOrEmptyRefreshToken,
            Success = false
        };

        public static GetChatsResponse UserNotFound => new()
        {
            Message = ResponseMessageCodes.UserNotFound,
            Success = false
        };

        public static GetChatsResponse FromSuccess(List<UserChatEntity> chats) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats.Select(x => new UserChat
            {
                Title = x.Chat.Title,
                Image = x.Chat.Image,
                LastMessage = x.Chat.Messages.Last().Content,
                LastMessageAuthor = x.Chat.Messages.Last().User.DisplayName
            }).ToList()
        };
    }
}
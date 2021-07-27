using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public class GetCurrentUserChatsResponse : ResponseBase<GetCurrentUserChatsResponse>
    {
        public List<UserChat> Chats { get; set; }

        public static GetCurrentUserChatsResponse FromSuccess(IEnumerable<UserChatEntity> chats) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats.Select(x => new UserChat
            {
                ChatId = x.ChatId,
                Title = x.Chat.Title,
                Image = x.Chat.Image,
                LastMessage = x.Chat.Messages.Any() ? x.Chat.Messages.OrderBy(x => x.Created).Last().Content : null,
                LastMessageAuthor = x.Chat.Messages.Any() ? x.Chat.Messages.OrderBy(x => x.Created).Last().User.DisplayName : null,
                LastMessageAt = x.Chat.Messages.Any() ? x.Chat.Messages.OrderBy(x => x.Created).Last().Created.ToShortTimeString() : null,
                MembersCount = x.Chat.MembersCount,
                IsMember = true
            }).ToList()
        };
    }
}
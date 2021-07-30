using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public record SearchChatsResponse : ChatResponseBase<SearchChatsResponse>
    {
        public List<UserChat> Chats { get; set; }

        public static SearchChatsResponse FromSuccess(IEnumerable<UserChatEntity> chats, string userId) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats.Select(x => new UserChat
                {
                    ChatId = x.ChatId,
                    Title = x.Chat.Title,
                    Image = x.Chat.Image,
                    LastMessage = x.Chat.Messages.Any() ? x.Chat.Messages.Last().Content : null,
                    LastMessageAuthor = x.Chat.Messages.Any() ? x.Chat.Messages.Last().User.DisplayName : null,
                    LastMessageAt = x.Chat.Messages.Any() ? x.Chat.Messages.Last().Created.ToShortTimeString() : null,
                    MembersCount = x.Chat.MembersCount,
                    IsMember = x.UserId == userId
                }).ToList()
        };
    }
}
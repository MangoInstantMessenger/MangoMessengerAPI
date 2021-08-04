using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public record SearchChatsResponse : ChatResponseBase<SearchChatsResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public List<UserChat> Chats { get; init; }

        public static SearchChatsResponse FromSuccess(IEnumerable<UserChatEntity> chats, string userId) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats.Select(userChatEntity =>
                new UserChat
                {
                    ChatId = userChatEntity.ChatId,
                    Title = userChatEntity.Chat.Title,
                    Image = userChatEntity.Chat.Image,
                    LastMessage = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.Last().Content
                        : null,
                    LastMessageAuthor = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.Last().User.DisplayName
                        : null,
                    LastMessageAt = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.Last().Created.ToShortTimeString()
                        : null,
                    MembersCount = userChatEntity.Chat.MembersCount,
                    IsMember = userChatEntity.UserId == userId
                }).ToList()
        };
    }
}
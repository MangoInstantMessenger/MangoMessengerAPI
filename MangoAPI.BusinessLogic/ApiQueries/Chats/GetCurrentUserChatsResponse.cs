using System.Collections.Generic;
using System.Linq;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    public record GetCurrentUserChatsResponse : ResponseBase<GetCurrentUserChatsResponse>
    {
        public List<Chat> Chats { get; init; }

        public static GetCurrentUserChatsResponse FromSuccess(IEnumerable<UserChatEntity> chats) => new()
        {
            Message = ResponseMessageCodes.Success,
            Success = true,
            Chats = chats.OrderByDescending(x => x.Chat.UpdatedAt).Select(userChatEntity => new Chat
            {
                ChatId = userChatEntity.ChatId,
                Title = userChatEntity.Chat.Title,
                Image = userChatEntity.Chat.Image,
                Description = userChatEntity.Chat.Description,
                LastMessage = userChatEntity.Chat.Messages.Any()
                      ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Last().Content
                      : null,
                LastMessageAuthor = userChatEntity.Chat.Messages.Any()
                      ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Last().User
                          .DisplayName
                      : null,
                LastMessageAt = userChatEntity.Chat.UpdatedAt?.ToShortTimeString() ?? (userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.CreatedAt)
                                                      .Last().CreatedAt
                                                      .ToShortTimeString()
                        : null),
                MembersCount = userChatEntity.Chat.MembersCount,
                ChatType = userChatEntity.Chat.ChatType,
                IsArchived = userChatEntity.IsArchived,
                IsMember = true,
            }).ToList(),
        };
    }
}
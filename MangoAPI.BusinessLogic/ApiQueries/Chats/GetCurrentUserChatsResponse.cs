namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using Domain.Constants;
    using Domain.Entities;
    using Models;
    using Responses;
    using System.Collections.Generic;
    using System.Linq;

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
                LastMessageAt = userChatEntity.Chat.UpdatedAt?.ToShortTimeString(),
                MembersCount = userChatEntity.Chat.MembersCount,
                ChatType = userChatEntity.Chat.ChatType,
                IsArchived = userChatEntity.IsArchived,
                IsMember = true,
            }).ToList(),
        };
    }
}
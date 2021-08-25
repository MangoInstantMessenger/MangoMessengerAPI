namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record GetCurrentUserChatsResponse : ResponseBase<GetCurrentUserChatsResponse>
    {
        public List<Chat> Chats { get; init; }

        public static GetCurrentUserChatsResponse FromSuccess(IEnumerable<UserChatEntity> chats)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Chats = chats.Select(userChatEntity => new Chat
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
                    LastMessageAt = userChatEntity.Chat.Messages.Any()
                        ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Last().CreatedAt
                            .ToShortTimeString()
                        : null,
                    MembersCount = userChatEntity.Chat.MembersCount,
                    ChatType = userChatEntity.Chat.ChatType,
                    IsArchived = userChatEntity.IsArchived,
                    IsMember = true,
                }).ToList(),
            };
        }
    }
}

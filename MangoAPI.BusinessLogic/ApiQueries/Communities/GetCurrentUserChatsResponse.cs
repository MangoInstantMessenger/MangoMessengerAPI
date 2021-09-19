using System.Collections.Generic;
using System.Linq;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.Domain.Enums;

namespace MangoAPI.BusinessLogic.ApiQueries.Communities
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
                ChatLogoImageUrl = StringService.GetDocumentUrl(userChatEntity.Chat.Image),
                Description = userChatEntity.Chat.Description,
                MembersCount = userChatEntity.Chat.MembersCount,
                CommunityType = (CommunityType) userChatEntity.Chat.CommunityType,
                IsArchived = userChatEntity.IsArchived,
                IsMember = true,
                LastMessage = userChatEntity.Chat.Messages.Any()
                    ? userChatEntity.Chat.Messages.OrderBy(messageEntity => messageEntity.CreatedAt).Select(x =>
                        new Message
                        {
                            MessageId = x.Id,
                            UserDisplayName = x.User.DisplayName,
                            MessageText = x.Content,
                            CreatedAt = x.CreatedAt.ToShortTimeString(),
                            UpdatedAt = x.UpdatedAt?.ToShortTimeString(),
                            IsEncrypted = x.IsEncrypted,
                            AuthorPublicKey = x.AuthorPublicKey,
                            MessageAuthorPictureUrl = StringService.GetDocumentUrl(x.User.Image),
                        }).Last()
                    : null,
            }).ToList(),
        };
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using MangoAPI.Application.Services;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record SearchChatMessagesResponse : ResponseBase<SearchChatMessagesResponse>
    {
        public List<Message> Messages { get; init; }

        public static SearchChatMessagesResponse FromSuccess(IEnumerable<MessageEntity> messages, Guid userId) =>
            new()
            {
                Messages = messages.Select(message =>
                    new Message
                    {
                        MessageId = message.Id,
                        ChatId = message.ChatId,
                        UserDisplayName = message.User.DisplayName,
                        MessageText = message.Content,
                        CreatedAt = message.CreatedAt.ToShortTimeString(),
                        UpdatedAt = message.UpdatedAt?.ToShortTimeString(),
                        Self = message.User.Id == userId,
                        IsEncrypted = message.IsEncrypted,
                        AuthorPublicKey = message.AuthorPublicKey,
                        MessageAuthorPictureUrl = StringService.GetDocumentUrl(message.User.Image),
                    }).ToList(),
                Message = ResponseMessageCodes.Success,
                Success = true
            };
    }
}
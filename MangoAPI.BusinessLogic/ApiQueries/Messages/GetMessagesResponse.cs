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
    public record GetMessagesResponse : ResponseBase<GetMessagesResponse>
    {
        public List<Message> Messages { get; init; }

        public static GetMessagesResponse FromSuccess(IEnumerable<MessageEntity> messages, Guid userId)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,

                Messages = messages.OrderBy(messageEntity => messageEntity.CreatedAt)
                    .Select(messageEntity => new Message
                    {
                        MessageId = messageEntity.Id,
                        MessageText = messageEntity.Content,
                        UpdatedAt = messageEntity.UpdatedAt?.ToShortTimeString(),
                        CreatedAt = messageEntity.CreatedAt.ToShortTimeString(),
                        UserDisplayName = messageEntity.User.DisplayName,
                        Self = messageEntity.User.Id == userId,
                        IsEncrypted = messageEntity.IsEncrypted,
                        AuthorPublicKey = messageEntity.AuthorPublicKey,
                        MessageAuthorPictureUrl = StringService.GetDocumentUrl(messageEntity.User.Image),
                    }).ToList(),

                Success = true,
            };
        }
    }
}
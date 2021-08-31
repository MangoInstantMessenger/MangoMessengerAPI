using System.Collections.Generic;
using System.Linq;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record GetMessagesResponse : MessageResponseBase<GetMessagesResponse>
    {
        public List<Message> Messages { get; init; }

        public static GetMessagesResponse FromSuccess(IEnumerable<MessageEntity> messages, UserEntity user)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,

                Messages = messages.OrderBy(messageEntity => messageEntity.CreatedAt)
                    .Select(messageEntity => new Message
                    {
                        MessageId = messageEntity.Id,
                        MessageText = messageEntity.Content,
                        EditedAt = messageEntity.UpdatedAt?.ToShortTimeString(),
                        SentAt = messageEntity.CreatedAt.ToShortTimeString(),
                        UserDisplayName = messageEntity.User.DisplayName,
                        Self = messageEntity.User.Id == user.Id,
                    }).ToList(),

                Success = true,
            };
        }
    }
}
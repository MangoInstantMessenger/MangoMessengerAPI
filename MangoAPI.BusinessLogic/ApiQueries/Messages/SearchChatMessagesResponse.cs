using System.Collections.Generic;
using System.Linq;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;

namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    public record SearchChatMessagesResponse : ResponseBase<SearchChatMessagesResponse>
    {
        public List<Message> Messages { get; set; }

        public static SearchChatMessagesResponse FromSuccess(List<MessageEntity> messages, UserEntity user) => new()
        {
            Messages = messages.Select(message =>
                new Message()
                {
                    MessageId = message.Id,
                    UserDisplayName = message.User.DisplayName,
                    MessageText = message.Content,
                    SentAt = message.CreatedAt.ToShortTimeString(),
                    EditedAt = message.UpdatedAt?.ToShortTimeString(),
                    Self = message.User.Id == user.Id
                }).ToList(),
            Message = ResponseMessageCodes.Success,
            Success = true
        };
    }
}
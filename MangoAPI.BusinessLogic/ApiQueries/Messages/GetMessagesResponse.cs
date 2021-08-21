namespace MangoAPI.BusinessLogic.ApiQueries.Messages
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record GetMessagesResponse : MessageResponseBase<GetMessagesResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public List<Message> Messages { get; init; }

        public static GetMessagesResponse FromSuccess(IEnumerable<MessageEntity> messages, UserEntity user)
        {
            return new ()
            {
                Message = ResponseMessageCodes.Success,

                Messages = messages.OrderBy(messageEntity => messageEntity.Created)
                    .Select(messageEntity => new Message
                    {
                        MessageText = messageEntity.Content,
                        EditedAt = messageEntity.Updated?.ToShortTimeString(),
                        SentAt = messageEntity.Created.ToShortTimeString(),
                        UserDisplayName = messageEntity.User.DisplayName,
                        Self = messageEntity.User.Id == user.Id,
                    }).ToList(),

                Success = true,
            };
        }
    }
}

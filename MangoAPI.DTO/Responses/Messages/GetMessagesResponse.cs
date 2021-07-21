﻿using System.Collections.Generic;
using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Messages
{
    public class GetMessagesResponse : MessageResponseBase<GetMessagesResponse>
    {
        public List<Message> Messages { get; set; }

        public static GetMessagesResponse FromSuccess(IEnumerable<MessageEntity> messages) => new()
        {
            Message = ResponseMessageCodes.Success,

            Messages = messages.Select(x => new Message
            {
                MessageText = x.Content,
                EditedAt = x.Updated,
                SentAt = x.Created,
                UserDisplayName = x.User.DisplayName
            }).OrderBy(x => x.SentAt).ToList(),

            Success = true
        };
    }
}
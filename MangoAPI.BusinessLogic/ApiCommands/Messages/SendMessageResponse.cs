using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageResponse : ResponseBase
{
    public string AttachmentUrl { get; set; }

    public Guid NewMessageId { get; set; }

    public DateTime CreatedAt { get; set; }

    public static SendMessageResponse FromSuccess(Guid newMessageId, string attachmentUrl, DateTime createdAt)
    {
        return new SendMessageResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            NewMessageId = newMessageId,
            AttachmentUrl = attachmentUrl,
            CreatedAt = createdAt
        };
    }
}
using System;
using System.ComponentModel;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageResponse : ResponseBase
{
    [DefaultValue("01108b4a-27f0-4be4-a9bd-e6e71feccd46")]
    public Guid MessageId { get; init; }

    public static SendMessageResponse FromSuccess(Guid messageId)
    {
        return new SendMessageResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            MessageId = messageId,
        };
    }
}
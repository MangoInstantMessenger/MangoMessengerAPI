using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain.Constants;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageResponse : ResponseBase
{
    // [DefaultValue("01108b4a-27f0-4be4-a9bd-e6e71feccd46")]
    // public Guid MessageId { get; init; }
    //
    // [DefaultValue("http://127.0.0.1:10000/devstoreaccount1/testcontainer/image.jpg")]
    // public string AttachmentUrl { get; init; }

    public Message MessageModel { get; init; }

    public static SendMessageResponse FromSuccess(Message messageModel)
    {
        return new SendMessageResponse
        {
            Success = true,
            Message = ResponseMessageCodes.Success,
            MessageModel = messageModel,
            // MessageId = messageId,
            // AttachmentUrl = attachmentUrl
        };
    }
}
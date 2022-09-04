using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageCommand(
        string MessageText,
        Guid UserId,
        Guid ChatId,
        string AttachmentUrl,
        string InReplayToAuthor,
        string InReplayToText,
        DateTime? CreatedAt)
    : IRequest<Result<SendMessageResponse>>;

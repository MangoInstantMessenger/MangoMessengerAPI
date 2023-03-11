using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageCommand(
        string MessageText,
        Guid UserId,
        Guid ChatId,
        string InReplayToAuthor,
        string InReplayToText,
        DateTime? CreatedAt,
        Guid? MessageId,
        IFormFile Attachment)
    : IRequest<Result<SendMessageResponse>>;
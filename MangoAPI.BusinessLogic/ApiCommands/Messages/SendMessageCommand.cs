using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageCommand(
        Guid UserId,
        Guid ChatId,
        string Text,
        string InReplyToUser,
        string InReplyToText,
        IFormFile Attachment)
    : IRequest<Result<SendMessageResponse>>;
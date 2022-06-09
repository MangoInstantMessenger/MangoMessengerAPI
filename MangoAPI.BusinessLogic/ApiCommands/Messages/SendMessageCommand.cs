using MediatR;
using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageCommand(string MessageText, Guid UserId, Guid ChatId, string AttachmentUrl, 
    string InReplayToAuthor, string InReplayToText) : IRequest<Result<SendMessageResponse>>;
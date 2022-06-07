using MediatR;
using System;
using MangoAPI.BusinessLogic.Responses;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages;

public record SendMessageCommand : IRequest<Result<SendMessageResponse>>
{
    public SendMessageCommand()
    {
        
    }

    public SendMessageCommand(Guid userId, Guid chatId)
    {
        MessageText = "test message";
        UserId = userId;
        ChatId = chatId;
        AttachmentUrl = " ";
        InReplayToAuthor = " ";
        InReplayToText = " ";
    }
    
    public string MessageText { get; init; }
    public Guid UserId { get; set; }
    public Guid ChatId { get; init; }
    public string AttachmentUrl { get; init; }
    public string InReplayToAuthor { get; init; }
    public string InReplayToText { get; init; }
}
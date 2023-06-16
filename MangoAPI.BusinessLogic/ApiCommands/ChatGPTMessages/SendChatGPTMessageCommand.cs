using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Responses;
using MediatR;
using System;

namespace MangoAPI.BusinessLogic.ApiCommands.ChatGPTMessages;

public sealed record SendChatGPTMessageCommand(string Text) : IRequest<Result<SendChatGPTMessageResponse>>
{
    public Guid UserId { get; init; }
}
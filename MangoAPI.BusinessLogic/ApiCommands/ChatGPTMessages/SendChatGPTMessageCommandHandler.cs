using FluentValidation;
using MangoAPI.BusinessLogic.ApiCommands.Contacts;
using MangoAPI.BusinessLogic.Models;
using MangoAPI.BusinessLogic.Responses;
using MangoAPI.Domain;
using MediatR;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text.Json;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic.ApiCommands.ChatGPTMessages;

public class SendChatGPTMessageCommandHandler : IRequestHandler<SendChatGPTMessageCommand, Result<SendChatGPTMessageResponse>>
{
    private readonly IChatGPTAdapter _adapter;
    private readonly ChatGPTOptions _options;
    private readonly ResponseFactory<SendChatGPTMessageResponse> responseFactory;
    private readonly IDistributedCache _provider;
    public SendChatGPTMessageCommandHandler(IChatGPTAdapter adapter, ChatGPTOptions options, IDistributedCache provider, ResponseFactory<SendChatGPTMessageResponse> responseFactory)
    {
        _adapter = adapter;
        _options = options;
        _provider = provider;
        this.responseFactory = responseFactory;
    }

    public async Task<Result<SendChatGPTMessageResponse>> Handle(SendChatGPTMessageCommand request, CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(request.Text))
        {
            throw new ValidationException("Message Text is empty");
        }

        var conversations = new List<Conversation>();
        var key = $"{request.UserId}_ChatGPT";
        var messagesString = _provider.GetString(key);
        if (!string.IsNullOrEmpty(messagesString))
        {
            conversations = JsonSerializer.Deserialize<List<Conversation>>(messagesString);
        }

        if (conversations.Count > _options.MaxRequestsPerPeriod)
        {
            var conversationResponse = new Conversation(
                conversations.Count,
                request.Text,
                false,
                _options.LimitViolationMessage);
            return responseFactory.ConflictResponse(conversationResponse.Response, _options.LimitViolationMessage);
        }

        var messages = conversations.Select(ChatGPTMessageConverter.Convert).SelectMany(m => m).ToList();
        var response = await _adapter.SendMessage(messages, request.Text);
        var leftMessagesCount = GetLeftMessagesCount(conversations);
        var conversation = new Conversation(leftMessagesCount, request.Text, !string.IsNullOrEmpty(response), response);
        conversations.Add(conversation);
        var serializedMessages = JsonSerializer.Serialize(conversations);

        await _provider.SetStringAsync(key, serializedMessages, new DistributedCacheEntryOptions
        {
            AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(_options.PeriodInDays)
        }, token: cancellationToken);

        return responseFactory.SuccessResponse(SendChatGPTMessageResponse.FromSuccess(conversation));
    }

    private int GetLeftMessagesCount(List<Conversation> conversations)
    {
        return _options.MaxRequestsPerPeriod - conversations.Count - 1;
    }
}
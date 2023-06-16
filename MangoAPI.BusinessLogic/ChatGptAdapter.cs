using MangoAPI.BusinessLogic.Models;
using MangoAPI.Domain;
using Microsoft.Extensions.Logging;
using OpenAI_API;
using OpenAI_API.Chat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic;

public class ChatGptAdapter : IChatGPTAdapter
{
    private readonly ILogger<ChatGptAdapter> _logger;
    private readonly ChatGPTOptions _options;
    private readonly OpenAIAPI _openAIAPI;

    public ChatGptAdapter(ILogger<ChatGptAdapter> logger, ChatGPTOptions options, OpenAIAPI openAiapi)
    {
        _logger = logger;
        _options = options;
        _openAIAPI = openAiapi;
    }
    public async Task<string> SendMessage(IList<ChatGPTMessage> messages, string request)
    {
        try
        {
            var chatMessages = messages
                .Select(MessageConverter.Convert)
                .ToList();
            chatMessages.Add(MessageConverter.Convert(request));

            var chatRequest = new ChatRequest
            {
                Model = _options.Model,
                Messages = chatMessages,
            };

            var text = (await _openAIAPI.Chat.CreateChatCompletionAsync(chatRequest)).Choices.FirstOrDefault()
                       ?.Message?.Content ??
                       _options.DefaultResponse;
            return text;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting response from ChatGPT");
        }

        return string.Empty;
    }
}
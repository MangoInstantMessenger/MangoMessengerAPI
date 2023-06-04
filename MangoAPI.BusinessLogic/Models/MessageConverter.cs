using OpenAI_API.Chat;
using System;

namespace MangoAPI.BusinessLogic.Models;

public class MessageConverter
{
    public static ChatMessage Convert(ChatGPTMessage chatGptMessage)
    {
        return chatGptMessage is null
            ? throw new ArgumentNullException(nameof(chatGptMessage))
            : new ChatMessage(ChatMessageRole.FromString(chatGptMessage.Role), chatGptMessage.Text);
    }

    public static ChatMessage Convert(string request)
    {
        return string.IsNullOrWhiteSpace(request)
            ? throw new ArgumentException($"{nameof(request)} is null or whitespace")
            : new ChatMessage(ChatMessageRole.User, request);
    }
}
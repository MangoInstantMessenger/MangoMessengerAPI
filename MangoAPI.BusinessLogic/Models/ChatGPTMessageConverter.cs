using System;

namespace MangoAPI.BusinessLogic.Models;

public class ChatGPTMessageConverter
{
    public static ChatGPTMessage[] Convert(Conversation conversation)
    {
        return conversation is null
            ? throw new ArgumentNullException(nameof(conversation))
            : (new ChatGPTMessage[]
        {
            new(MessageAuthors.User, conversation.Request),
            new(MessageAuthors.AI, conversation.Response)
        });
    }
}
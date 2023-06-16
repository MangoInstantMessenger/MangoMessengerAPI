using System.Collections.Generic;
using System.Threading.Tasks;

namespace MangoAPI.BusinessLogic;

public interface IChatGPTAdapter
{
    Task<string> SendMessage(IList<ChatGPTMessage> messages, string request);
}

public sealed record ChatGPTMessage(string Role, string Text);
namespace MangoAPI.BusinessLogic.Models;

public sealed record Conversation(int LeftMessagesCount, string Request, bool IsResponseSucceed, string Response);

public static class MessageAuthors
{
    public const string User = "user";
    public const string AI = "assistant";
}
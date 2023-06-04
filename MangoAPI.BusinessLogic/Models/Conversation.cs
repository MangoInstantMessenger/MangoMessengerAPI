namespace MangoAPI.BusinessLogic.Models;

public sealed record Conversation(int LeftMessagesCount, string Request, bool IsResponseSucceed, string Response);

public static class MessageAuthors
{
    public static readonly string User = "user";
    public static readonly string AI = "assistant";
}
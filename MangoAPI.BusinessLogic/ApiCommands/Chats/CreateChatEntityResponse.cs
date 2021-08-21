namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record CreateChatEntityResponse : ChatResponseBase<CreateChatEntityResponse>
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        // ReSharper disable once MemberCanBePrivate.Global
        public string ChatId { get; init; }

        public static CreateChatEntityResponse FromSuccess(ChatEntity chatEntity)
        {
            return new ()
            {
                ChatId = chatEntity.Id,
                Message = ResponseMessageCodes.Success,
                Success = true,
            };
        }
    }
}

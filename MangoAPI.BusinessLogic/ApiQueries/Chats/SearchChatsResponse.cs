namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using Domain.Constants;
    using Models;
    using Responses;
    using System.Collections.Generic;

    public record SearchChatsResponse : ChatResponseBase<SearchChatsResponse>
    {
        public List<Chat> Chats { get; init; }

        public static SearchChatsResponse FromSuccess(List<Chat> chats)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Chats = chats,
            };
        }
    }
}
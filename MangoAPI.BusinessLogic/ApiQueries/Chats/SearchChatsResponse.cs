namespace MangoAPI.BusinessLogic.ApiQueries.Chats
{
    using System.Collections.Generic;
    using System.Linq;
    using Models;
    using Responses;
    using Domain.Constants;
    using Domain.Entities;

    public record SearchChatsResponse : ChatResponseBase<SearchChatsResponse>
    {
        public List<Chat> Chats { get; init; }

        public static SearchChatsResponse FromSuccess(IEnumerable<ChatEntity> chats)
        {
            return new()
            {
                Message = ResponseMessageCodes.Success,
                Success = true,
                Chats = chats.Select(x =>
                    new Chat
                    {
                        ChatId = x.Id,
                        Title = x.Title,
                        Image = x.Image,
                        LastMessage = x.Messages.Any()
                            ? x.Messages.Last().Content
                            : null,
                        LastMessageAuthor = x.Messages.Any()
                            ? x.Messages.Last().User.DisplayName
                            : null,
                        LastMessageAt = x.Messages.Any()
                            ? x.Messages.Last().Created.ToShortTimeString()
                            : null,
                        MembersCount = x.MembersCount,
                        ChatType = x.ChatType,
                    }).ToList(),
            };
        }
    }
}

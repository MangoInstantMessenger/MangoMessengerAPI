using System.Linq;
using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using MangoAPI.DTO.Models;

namespace MangoAPI.DTO.Responses.Chats
{
    public class GetChatByIdResponse : ChatResponseBase<GetChatByIdResponse>
    {
        public Chat Chat { get; set; }

        public static GetChatByIdResponse FromSuccess(ChatEntity chat) => new()
        {
            Message = ResponseMessageCodes.Success,

            Chat = new Chat
            {
                Title = chat.Title,
                Image = chat.Image,
                Messages = chat.Messages.Select(x => new Message
                {
                    MessageText = x.Content,
                    EditedAt = x.Updated,
                    SentAt = x.Created,
                    UserDisplayName = x.User.DisplayName
                }).ToList(),
            },

            Success = true
        };
    }
}
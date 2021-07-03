using MangoAPI.DTO.Responses.Messages;

namespace MangoAPI.DTO.Commands.Messages
{
    public class SendMessageCommand : AuthorizedCommand<SendMessageResponse>
    {
        public string Content { get; set; }
        public int ChatId { get; set; }
    }
}
using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public record SendMessageCommand : IRequest<SendMessageResponse>
    {
        public string MessageText { get; set; }
        public string UserId { get; set; }
        public string ChatId { get; set; }
    }
}
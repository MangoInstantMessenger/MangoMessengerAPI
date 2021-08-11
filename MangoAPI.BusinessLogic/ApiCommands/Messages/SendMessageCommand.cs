using MangoAPI.DTO.Responses.Messages;
using MediatR;

namespace MangoAPI.DTO.ApiCommands.Messages
{
    public record SendMessageCommand : IRequest<SendMessageResponse>
    {
        public string MessageText { get; init; }
        public string UserId { get; init; }
        public string ChatId { get; init; }
    }
}
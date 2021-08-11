using MangoAPI.BusinessLogic.Responses.Messages;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Messages
{
    public record SendMessageCommand : IRequest<SendMessageResponse>
    {
        public string MessageText { get; init; }
        public string UserId { get; init; }
        public string ChatId { get; init; }
    }
}
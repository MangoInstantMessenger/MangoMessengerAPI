using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record JoinChatCommand : IRequest<ResponseBase>
    {
        public string ChatId { get; init; }
        public string UserId { get; init; }
    }
}
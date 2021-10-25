using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record JoinChatCommand : IRequest<Result<ResponseBase>>
    {
        public Guid ChatId { get; init; }
        public Guid UserId { get; init; }
    }
}
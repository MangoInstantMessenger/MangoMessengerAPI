using System;
using MangoAPI.BusinessLogic.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateChatCommand : IRequest<CreateCommunityResponse>
    {
        public Guid PartnerId { get; init; }
        public Guid UserId { get; init; }
        public ChatType ChatType { get; init; }
    }
}
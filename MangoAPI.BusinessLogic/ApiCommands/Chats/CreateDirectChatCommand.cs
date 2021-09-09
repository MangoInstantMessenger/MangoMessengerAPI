using System;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateDirectChatCommand : IRequest<CreateChatEntityResponse>
    {
        public Guid PartnerId { get; init; }
        public Guid UserId { get; init; }
    }
}
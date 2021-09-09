using System;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Chats
{
    public record CreateGroupCommand : IRequest<CreateChatEntityResponse>
    {
        public ChatType GroupType { get; init; }
        public string GroupTitle { get; init; }
        public string GroupDescription { get; init; }

        public Guid UserId { get; init; }
    }
}
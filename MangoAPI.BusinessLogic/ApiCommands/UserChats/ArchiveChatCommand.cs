using System;
using MangoAPI.BusinessLogic.Responses;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.UserChats
{
    public record ArchiveChatCommand : IRequest<ResponseBase>
    {
        public Guid ChatId { get; init; }
        public Guid UserId { get; init; }
    }
}
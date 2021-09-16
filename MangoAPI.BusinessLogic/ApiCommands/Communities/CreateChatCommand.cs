using System;
using MangoAPI.Domain.Enums;
using MediatR;

namespace MangoAPI.BusinessLogic.ApiCommands.Communities
{
    public record CreateChatCommand : IRequest<CreateCommunityResponse>
    {
        public Guid PartnerId { get; init; }
        public Guid UserId { get; init; }
        public CommunityType CommunityType { get; init; }
    }
}